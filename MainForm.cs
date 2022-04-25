using Notes.Models;
using Notes.Core;

namespace Notes
{
    public partial class MainForm : Form
    {
        private NoteContext _context { get; }
        private TextForm? _openForm = null;
        public MainForm()
        {
            InitializeComponent();

            _context = new NoteContext();

            _context.Database.EnsureCreated();

            if(_context.Notes.Count() == 0){
                Note note = new()
                {
                    Name = "My First Note",
                    Path = Guid.NewGuid()
                };

                _context.Notes.Add(note);

                _context.SaveChanges();
            }

            Build();
        }

        private void Build()
        {
            LbxNotes.Items.Clear();

            foreach (Note note in _context.Notes)
            {
                LbxNotes.Items.Add(note.Name);
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Note? find = GetNoteByName(TbxAdd.Text);

            if (TbxAdd.Text != "" && find == null)
            {
                Note note = new()
                {
                    Name = TbxAdd.Text,
                    Path = Guid.NewGuid()
                };

                TbxAdd.Clear();

                _context.Notes.Add(note);

                _context.SaveChanges();

                Build();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (LbxNotes.SelectedItem != null && TbxEdit.Text != "")
            {
                Note? find = GetNoteByName(LbxNotes.Text);

                if (find != null)
                {
                    if (_openForm != null && _openForm.Text == find.Name)
                    {
                        _openForm.Close();
                    }

                    Note? note = _context.Notes.Find(find.Id);

                    if (note != null)
                    {
                        note.Name = TbxEdit.Text;
                        _context.SaveChanges();
                    }

                    TbxEdit.Clear();

                    Build();
                }
            }
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            if (_openForm == null)
            {
                if (LbxNotes.SelectedItem != null)
                {
                    Note? find = GetNoteByName(LbxNotes.Text);

                    if (find != null)
                    {
                        _openForm = new(GetFilePath(find.Path));

                        _openForm.Text = find.Name;

                        _openForm.FormClosed += (obj, args) =>
                        {
                            _openForm.Dispose();
                            _openForm = null;
                            
                            GC.Collect();
                        };

                        _openForm.Show();
                    }
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (LbxNotes.SelectedItem != null)
            {
                Note? find = GetNoteByName(LbxNotes.Text);
                if (find != null)
                {
                    if (_openForm != null && _openForm.Text == find.Name)
                    {
                        _openForm.Close();
                    }

                    Deleter.DeleteFile(GetFilePath(find.Path));

                    _context.Notes.Remove(find);

                    _context.SaveChanges();

                    Build();
                }
            }
        }

        private Note? GetNoteByName(string name)
        {
            return _context.Notes.ToList().Find(f => f.Name == name);
        }

        private static string GetFilePath(Guid id)
        {
            return "Static Files\\" + id + ".rtf";
        }
    }
}