using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KraftHeinzUI
{
    public partial class Form1 : Form
    {
        private bool linked = false;

        DataGridViewRow row = new DataGridViewRow();

        public Form1()
        {
            InitializeComponent();
            departments_tbBindingSource.CurrentChanged += Departments_tbBindingSource_CurrentChanged;
            positions_tbBindingSource.CurrentChanged += Positions_tbBindingSource_CurrentChanged;
        }

        private void Departments_tbBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            depCounter.Text = $"{departments_tbBindingSource.Position + 1} of {departments_tbBindingSource.Count}";
        }

        private void Positions_tbBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            posCounter.Text = $"{positions_tbBindingSource.Position + 1} of {positions_tbBindingSource.Count}";
        }

        private void departments_tbBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            departments_tbBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(kraftHeinzDataSet);
        }

        private void positions_tbBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            positions_tbBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(kraftHeinzDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kraftHeinzDataSet.positions_tb' table. You can move, or remove it, as needed.
            positions_tbTableAdapter.Fill(kraftHeinzDataSet.positions_tb);
            // TODO: This line of code loads data into the 'kraftHeinzDataSet.departments_tb' table. You can move, or remove it, as needed.
            departments_tbTableAdapter.Fill(kraftHeinzDataSet.departments_tb);

        }

        private void depMoveFirst_Click(object sender, EventArgs e)
        {
            departments_tbBindingSource.MoveFirst();
        }

        private void depMovePrev_Click(object sender, EventArgs e)
        {
            departments_tbBindingSource.MovePrevious();
        }

        private void depMoveNext_Click(object sender, EventArgs e)
        {
            departments_tbBindingSource.MoveNext();
        }

        private void depMoveLast_Click(object sender, EventArgs e)
        {
            departments_tbBindingSource.MoveLast();
        }

        private void depAddNew_Click(object sender, EventArgs e)
        {
            departments_tbBindingSource.AddNew();
        }

        private void depDeleteCurrent_Click(object sender, EventArgs e)
        {
            departments_tbBindingSource.RemoveCurrent();
        }

        private void depSave_Click(object sender, EventArgs e)
        {
            Validate();
            departments_tbBindingSource.EndEdit();
            departments_tbTableAdapter.Update(kraftHeinzDataSet.departments_tb);
        }

        private void btnAddDep_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(insDepName.Text))
                    throw new Exception("Department name is mandatory");

                if (string.IsNullOrWhiteSpace(insDepDesc.Text))
                    throw new Exception("Department description is mandatory");

                departments_tbTableAdapter.Insert(insDepName.Text, insDepDesc.Text);
                departments_tbTableAdapter.Fill(kraftHeinzDataSet.departments_tb);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void posMoveFirst_Click(object sender, EventArgs e)
        {
            positions_tbBindingSource.MoveFirst();
        }

        private void posMovePrev_Click(object sender, EventArgs e)
        {
            positions_tbBindingSource.MovePrevious();
        }

        private void posMoveNext_Click(object sender, EventArgs e)
        {
            positions_tbBindingSource.MoveNext();
        }

        private void posMoveLast_Click(object sender, EventArgs e)
        {
            positions_tbBindingSource.MoveLast();
        }

        private void posAddNew_Click(object sender, EventArgs e)
        {
            positions_tbBindingSource.AddNew();
        }

        private void posDeleteCurrent_Click(object sender, EventArgs e)
        {
            positions_tbBindingSource.RemoveCurrent();
        }

        private void posSave_Click(object sender, EventArgs e)
        {
            Validate();
            positions_tbBindingSource.EndEdit();
            positions_tbTableAdapter.Update(kraftHeinzDataSet.positions_tb);
        }

        private void btnAppPos_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(insPosName.Text))
                    throw new Exception("Position name is mandatory");

                if (string.IsNullOrWhiteSpace(insPosDesc.Text))
                    throw new Exception("Position description is mandatory");

                positions_tbTableAdapter.Insert((int)insPosIdDep.Value, insPosName.Text, insPosDesc.Text);
                positions_tbTableAdapter.Fill(kraftHeinzDataSet.positions_tb);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFindDep_Click(object sender, EventArgs e)
        {
            int foundIndex = departments_tbBindingSource.Find(depCol.Text, txtFindDep.Text);
            if (foundIndex == -1)
                MessageBox.Show("Record not found");
            else
                departments_tbBindingSource.Position = foundIndex;
        }

        private void btnFindPos_Click(object sender, EventArgs e)
        {
            int foundIndex = positions_tbBindingSource.Find(posCol.Text, txtFindPos.Text);
            if (foundIndex == -1)
                MessageBox.Show("Record not found");
            else
                positions_tbBindingSource.Position = foundIndex;
        }

        private void btnFindPKDep_Click(object sender, EventArgs e)
        {
            DataRow r1 = kraftHeinzDataSet.departments_tb.FindByidDepartment(Convert.ToInt32(txtFindPKDep.Text));
            if (r1 == null)
            {
                MessageBox.Show("Record not found");
                return;
            }
            departments_tbBindingSource.Position = r1.Table.Rows.IndexOf(r1);
            MessageBox.Show(r1.Field<string>("departmentName").ToString() + ", " + r1.Field<string>("departmentDescription").ToString());

        }

        private void btnFindPKPos_Click(object sender, EventArgs e)
        {
            DataRow r1 = kraftHeinzDataSet.positions_tb.FindByidPosition(Convert.ToInt32(txtFindPKPos.Text));
            if (r1 == null)
            {
                MessageBox.Show("Record not found");
                return;
            }
            positions_tbBindingSource.Position = r1.Table.Rows.IndexOf(r1);
            MessageBox.Show(r1.Field<int>("idDepartment").ToString() + ", " + r1.Field<string>("positionName").ToString() + ", " + r1.Field<string>("positionDescription").ToString());
        }

        private void btnDepSort_Click(object sender, EventArgs e)
        {
            departments_tbBindingSource.Sort = $"{depSortF.Text} {depSortDir.Text}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            positions_tbBindingSource.Sort = $"{posSortF.Text} {posSortDir.Text}";
        }

        private void btnPosFilter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(posFilterValue.Text))
            {
                positions_tbBindingSource.Filter = "";
            }
            else
            {
                positions_tbBindingSource.Filter = $"{posFilField.Text} LIKE '{posFilterValue.Text}'";
            }
        }

        private void btnDepFilter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(depFilterValue.Text))
            {
                departments_tbBindingSource.Filter = "";
            }
            else
            {
                departments_tbBindingSource.Filter = $"{depFilField.Text} LIKE '{depFilterValue.Text}'";
            }
        }

        private void LinkBtn_Click_1(object sender, EventArgs e)
        {
            if (linked == false)
            {
                row = departments_tbDataGridView.SelectedRows[0];
                positions_tbDataGridView.DataSource = ((DataRowView)departments_tbDataGridView.SelectedRows[0].DataBoundItem).Row.GetChildRows("departments_tb_positions_tb").CopyToDataTable();
                linked = true;
            }
            else
            {
                if (departments_tbDataGridView.SelectedRows[0] != row)
                {
                    positions_tbDataGridView.DataSource = ((DataRowView)departments_tbDataGridView.SelectedRows[0].DataBoundItem).Row.GetChildRows("departments_tb_positions_tb").CopyToDataTable();
                    row = departments_tbDataGridView.SelectedRows[0];
                }
                else
                {
                    positions_tbDataGridView.DataSource = positions_tbBindingSource;
                    linked = false;
                }
            }
        }
    }
}
