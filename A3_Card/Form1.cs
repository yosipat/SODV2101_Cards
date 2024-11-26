using System;
using System.Collections.Immutable;
using System.ComponentModel;

namespace A3_Card
{
    public partial class Form1 : Form
    {
        private BindingList<Artist> artists = new BindingList<Artist>(Data.GetArtists());
        private BindingList<Group> groups = new BindingList<Group>(Data.GetGroups());

        int count;
        public Form1()
        {
            InitializeComponent();
            count = artists.Count(); // original data count for next Id
            LoadData(listView1);

        }

        private void LoadData(ListView listView)
        {
            listView.Items.Clear();
            listView.Columns.Add("Id", 40, HorizontalAlignment.Left);
            listView.Columns.Add("Artist Name", 160, HorizontalAlignment.Left);

            // artists = new BindingList<Artist>(artists.OrderBy(a => a.Name).ToList());
            // or
            artists = new BindingList<Artist>((from a in artists orderby a.Name select a).ToList());

            foreach (Artist a in artists)
            {
                ListViewItem item = new ListViewItem(a.Id.ToString());
                item.SubItems.Add(a.Name);
                listView.Items.Add(item);

            }
            card1.Visible = false;
        }

        private void UpdateListView()
        {
            listView1.Items.Clear();

            txtName.Text = "";
            txtAge.Text = "";
            txtAlbum.Text = "";
            txtImg.Text = "";
            txtGroupId.Text = "";

            artists = new BindingList<Artist>((from a in artists orderby a.Name select a).ToList());

            foreach (Artist a in artists)
            {
                ListViewItem item = new ListViewItem(a.Id.ToString());
                item.SubItems.Add(a.Name);
                listView1.Items.Add(item);

            }
            card1.Visible = false;

        }



        private void ListView1_SelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Get the selected item from the ListView
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // Get the text from the selected item (e.g., id)
                int id =Convert.ToInt32(selectedItem.Text);

                // Find data from Id
                var info = artists.Where(a => a.Id.Equals(id)).Select(a => a).ToList();

                foreach (Artist a in info)
                {
                    Group group = groups.FirstOrDefault(g => g.Id == a.GroupId);
                    string GroupName = group != null ? group.GroupName : "Unknown";
                    string ColorCode = group != null ? group.ColorCode : "Unknown";

                    // fill info to txtbox
                    txtName.Text = a.Name;
                    txtAge.Text = a.Age.ToString();
                    txtAlbum.Text = a.DebutAlbum;
                    txtImg.Text = a.Img;
                    txtGroupId.Text = a.GroupId.ToString();

                    // show artist card
                    card1.Visible = true;
                    card1.Name = a.Name;
                    card1.Age = a.Age.ToString();
                    card1.Album = a.DebutAlbum;
                    card1.GroupName = GroupName;
                    card1.Img = a.Img;
                    card1.bgColor = ColorCode;

                }

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                artists.Add(new Artist
                {
                    Id = ++count,
                    Name = txtName.Text.ToUpper(),
                    Age = Convert.ToInt32(txtAge.Text),
                    DebutAlbum = txtAlbum.Text,
                    Img = txtImg.Text,
                    GroupId = Convert.ToInt32(txtGroupId.Text)
                });
                MessageBox.Show("Added data successfully");
                UpdateListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    // Get the selected item from the ListView
                    ListViewItem selectedItem = listView1.SelectedItems[0];

                    // Get the text from the selected item (e.g., id)
                    int id = Convert.ToInt32(selectedItem.Text);

                    // Find data from Id
                    var info = artists.Where(a => a.Id.Equals(id)).Select(a => a).ToList();

                    foreach (Artist a in info)
                    {
                        a.Name = txtName.Text.ToUpper();
                        a.Age = Convert.ToInt32(txtAge.Text);
                        a.DebutAlbum = txtAlbum.Text;
                        a.Img = txtImg.Text;
                        a.GroupId = Convert.ToInt32(txtGroupId.Text);
                    }

                    MessageBox.Show("Updated data successfully");
                    UpdateListView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    // Get the selected item from the ListView
                    ListViewItem selectedItem = listView1.SelectedItems[0];

                    // Get the text from the selected item (e.g., id)
                    int id = Convert.ToInt32(selectedItem.Text);

                    // Find data from Id
                    var info = artists.Where(a => a.Id.Equals(id)).Select(a => a).ToList();

                    foreach (Artist a in info) {
                        artists.Remove(a);
                    }

                    MessageBox.Show("Deleted data successfully");
                    UpdateListView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
