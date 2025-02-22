using Newtonsoft.Json;
using System.Xml.Linq;

namespace Real_life_problem_using_JSON_file
{
    public partial class Form1 : Form
    {
        private List<Contact> contacts = new List<Contact>();
        private string filePath = "contacts.json";

        public Form1()
        {
            InitializeComponent();
            LoadContacts();
        }
        private void LoadContacts()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                contacts = JsonConvert.DeserializeObject<List<Contact>>(json) ?? new List<Contact>();
            }
            UpdateContactList();
        }

        private void SaveContacts()
        {
            string json = JsonConvert.SerializeObject(contacts, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        private void UpdateContactList()
        {
            dgvContacts.DataSource = null;
            dgvContacts.DataSource = contacts;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                contacts.Add(new Contact { Name = txtName.Text, Phone = txtPhone.Text });
                txtName.Clear();
                txtPhone.Clear();
                SaveContacts();
                UpdateContactList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvContacts.SelectedRows.Count > 0)
            {
                int index = dgvContacts.SelectedRows[0].Index;
                contacts.RemoveAt(index);
                SaveContacts();
                UpdateContactList();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();
            var filteredContacts = contacts.Where(c => c.Name.ToLower().Contains(searchText) || c.Phone.Contains(searchText)).ToList();
            dgvContacts.DataSource = filteredContacts;
        }
    }
}
