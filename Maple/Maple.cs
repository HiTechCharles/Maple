using System;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;

namespace Maple
{
    /// <summary>
    /// Main form for the Maple task management application.
    /// </summary>
    public partial class Maple : Form, IDisposable
    {
        #region Constants
        private const int SpeechRate = 3;
        private const int SpeechVolume = 100;
        #endregion

        #region Fields
        private readonly string storageDir = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "Maple");
        private readonly string todoFileName = "ToDo.txt";
        private readonly string doneFileName = "Done.txt";
        private readonly SpeechSynthesizer taskReader = new SpeechSynthesizer();
        private bool disposed = false;
        #endregion

        #region Initialization
        public Maple()
        {
            InitializeComponent();
            InitializeSpeechSynthesizer();
        }

        private void InitializeSpeechSynthesizer()
        {
            taskReader.Rate = SpeechRate;
            taskReader.Volume = SpeechVolume;
        }
        #endregion

        #region Lifecycle Events
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            try
            {
                LoadState();
            }
            catch (Exception ex)
            {
                // TODO: Add proper logging mechanism
                // For now, show error to user for critical load failures
                MessageBox.Show(
                    $"Failed to load saved tasks: {ex.Message}",
                    "Load Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            try
            {
                SaveState();
            }
            catch (Exception ex)
            {
                // TODO: Add proper logging
                var result = MessageBox.Show(
                    $"Failed to save tasks: {ex.Message}\n\nClose anyway?",
                    "Save Error",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Error);

                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                    return;
                }
            }
            base.OnFormClosing(e);
        }
        #endregion

        #region Task Management
        private void AddListBTN_Click(object sender, EventArgs e)
        {
            var text = ItemsCB.Text?.Trim();

            if (string.IsNullOrEmpty(text))
            {
                SystemSounds.Exclamation.Play();
                return;
            }

            // Avoid exact duplicate entries in the ToDo list
            if (!ToDoLB.Items.Contains(text))
            {
                ToDoLB.Items.Add(text);
                ItemsCB.Text = string.Empty;
                UpdateProgress();
            }
            else
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show(
                    "This task already exists in the ToDo list.",
                    "Duplicate Task",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (ToDoLB.SelectedIndex == -1)
            {
                SystemSounds.Exclamation.Play();
                return;
            }

            ToDoLB.Items.RemoveAt(ToDoLB.SelectedIndex);
            UpdateProgress();
        }

        private void CompleteBTN_Click(object sender, EventArgs e)
        {
            if (ToDoLB.SelectedIndex == -1)
            {
                SystemSounds.Exclamation.Play();
                return;
            }

            var item = ToDoLB.SelectedItem;
            if (item != null)
            {
                CompleteLB.Items.Add(item);
                ToDoLB.Items.RemoveAt(ToDoLB.SelectedIndex);
                UpdateProgress();
            }
        }
        #endregion

        #region Progress Management
        private void UpdateProgress()
        {
            // Ensure controls exist (designer may change) and avoid division by zero
            if (AllDonePB == null || ToDoLB == null || CompleteLB == null)
                return;

            int toDoCount = ToDoLB.Items.Count;
            int doneCount = CompleteLB.Items.Count;
            int totalJobs = toDoCount + doneCount;

            if (totalJobs == 0)
            {
                AllDonePB.Value = AllDonePB.Minimum;
                return;
            }

            double percent = (double)doneCount / totalJobs * 100.0;
            int percentValue = Convert.ToInt32(Math.Round(percent));

            // Clamp to progress bar range
            percentValue = Math.Max(AllDonePB.Minimum, Math.Min(AllDonePB.Maximum, percentValue));

            AllDonePB.Value = percentValue;
        }
        #endregion

        #region Persistence
        private void LoadState()
        {
            EnsureStorageDirectoryExists();

            var todoPath = GetTodoFilePath();
            var donePath = GetDoneFilePath();

            LoadItemsFromFile(todoPath, ToDoLB);
            LoadItemsFromFile(donePath, CompleteLB);

            UpdateProgress();
        }

        private void SaveState()
        {
            EnsureStorageDirectoryExists();

            var todoPath = GetTodoFilePath();
            var donePath = GetDoneFilePath();

            SaveItemsToFile(todoPath, ToDoLB);
            SaveItemsToFile(donePath, CompleteLB);
        }

        private void EnsureStorageDirectoryExists()
        {
            if (!Directory.Exists(storageDir))
            {
                Directory.CreateDirectory(storageDir);
            }
        }

        private string GetTodoFilePath() => Path.Combine(storageDir, todoFileName);
        private string GetDoneFilePath() => Path.Combine(storageDir, doneFileName);

        private void LoadItemsFromFile(string filePath, ListBox listBox)
        {
            if (!File.Exists(filePath))
                return;

            var lines = File.ReadAllLines(filePath)
                .Where(l => !string.IsNullOrWhiteSpace(l))
                .Select(l => l.Trim())
                .ToArray();

            if (lines.Length > 0)
            {
                listBox.Items.AddRange(lines);
            }
        }

        private void SaveItemsToFile(string filePath, ListBox listBox)
        {
            var lines = listBox.Items
                .Cast<object>()
                .Select(o => o?.ToString() ?? string.Empty)
                .ToArray();

            File.WriteAllLines(filePath, lines);
        }
        #endregion

        #region Menu Handlers
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "This will clear all tasks and delete saved files. Continue?",
                "Confirm Reset",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            // Stop any speech and clear lists
            StopSpeech();
            ToDoLB.Items.Clear();
            CompleteLB.Items.Clear();
            UpdateProgress();

            // Delete persisted files
            DeleteStorageFiles();
        }

        private void speakListsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopSpeech();

            SpeakTodoList();
            SpeakCompletedList();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Speech Methods
        private void StopSpeech()
        {
            try
            {
                taskReader.SpeakAsyncCancelAll();
            }
            catch (Exception)
            {
                // Ignore speech cancellation errors
            }
        }

        private void SpeakTodoList()
        {
            if (ToDoLB.Items.Count > 0)
            {
                taskReader.SpeakAsync("Tasks to do are as follows.");
                foreach (var item in ToDoLB.Items)
                {
                    taskReader.SpeakAsync($"{item}.");
                }
                taskReader.SpeakAsync($"Your tasks are {AllDonePB.Value} percent complete.");
            }
            else
            {
                taskReader.SpeakAsync("There are no tasks to do.");
            }
        }

        private void SpeakCompletedList()
        {
            if (CompleteLB.Items.Count > 0)
            {
                taskReader.SpeakAsync("Tasks completed are as follows.");
                foreach (var item in CompleteLB.Items)
                {
                    taskReader.SpeakAsync($"{item}.");
                }
            }
            else
            {
                taskReader.SpeakAsync("There are no tasks completed.");
            }
        }
        #endregion

        #region File Management
        private void DeleteStorageFiles()
        {
            try
            {
                var todoPath = GetTodoFilePath();
                var donePath = GetDoneFilePath();

                if (File.Exists(todoPath))
                    File.Delete(todoPath);
                if (File.Exists(donePath))
                    File.Delete(donePath);
            }
            catch (Exception)
            {
                // Ignore file delete errors
            }
        }
        #endregion

        #region IDisposable Implementation
        protected override void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    taskReader?.Dispose();
                }
                disposed = true;
            }
            base.Dispose(disposing);
        }
        #endregion
    }
}