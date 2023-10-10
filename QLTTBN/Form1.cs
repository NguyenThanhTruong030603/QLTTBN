using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTTBN.Model1;

namespace QLTTBN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void FillTTBNCombobox(List<TinhTrang> listTTs)
        {
            this.CBTT.DataSource = listTTs;
            this.CBTT.DisplayMember = "TenTT";
            this.CBTT.ValueMember = "MaTT";
        }
        private void FillBNCombobox(List<BenhNhan> listBNs)
        {
             listBNs.Insert(0, new BenhNhan());
           

            this.cbBNLNT.DataSource = listBNs;
            this.cbBNLNT.DisplayMember = "MaBN";
            this.cbBNLNT.ValueMember = "MaBN";
        }
        private void BindGrid(List<BenhNhan> listBNs)
        {

            dgvBN.Rows.Clear();
            foreach (var item in listBNs)
            {
                int index = dgvBN.Rows.Add();
                dgvBN.Rows[index].Cells[0].Value = item.MaBN;
                dgvBN.Rows[index].Cells[1].Value = item.TenBN;
                if(item.TinhTrang!= null)
                dgvBN.Rows[index].Cells[2].Value = item.TinhTrang.TenTT ;
                // dgvBN.Rows[index].Cells[3].Value = item.BNTXG;
               
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                BenhNhanContext context = new BenhNhanContext();
                List<TinhTrang> listTTs = context.TinhTrangs.ToList();
                List<BenhNhan> listBNs = context.BenhNhans.ToList();

                FillBNCombobox(listBNs);
                FillTTBNCombobox(listTTs);
                BindGrid(listBNs);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void them_Click(object sender, EventArgs e)
        {
            try
            {
                if (tenBN.Text == "" || CBTT.Text == "")
                  throw new Exception("Vui lòng nhập đầy đủ thông tin bệnh nhân!");
                if(maBN.Text.Length != 6)
                    throw new Exception("Mã bệnh nhân phải có 6 kí tự!");
                if(cbBNLNT.Text == maBN.Text)
                    throw new Exception("Không thể tự lây nhiễm chính mình!");
              
                BenhNhanContext context = new BenhNhanContext();
                BenhNhan dbUpdate = context.BenhNhans.FirstOrDefault(p => p.MaBN == maBN.Text);

                if (dbUpdate == null)
                {
                    dbUpdate = new BenhNhan();
                    dbUpdate.MaBN = maBN.Text;
                    context.BenhNhans.Add(dbUpdate);
                }
                dbUpdate.TenBN = tenBN.Text.Trim();
                dbUpdate.MaTT = (int)CBTT.SelectedValue;
                dbUpdate.GhiChu = ghichu.Text.Trim();
                dbUpdate.BNTXG = (string)cbBNLNT.SelectedValue;     

                context.SaveChanges();                          
                BindGrid(new BenhNhanContext().BenhNhans.ToList());
                MessageBox.Show("“Cập nhật dữ liệu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       

        private void dgvBN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;
            if(RowIndex>=0)
            {
                maBN.Text = dgvBN.Rows[RowIndex].Cells[0].Value.ToString();
                tenBN.Text = dgvBN.Rows[RowIndex].Cells[1].Value.ToString();
                CBTT.Text = dgvBN.Rows[RowIndex].Cells[2].Value.ToString();
                BenhNhanContext context = new BenhNhanContext();
                BenhNhan db = context.BenhNhans.FirstOrDefault(p => p.MaBN == maBN.Text);
                ghichu.Text = db.GhiChu;
                cbBNLNT.Text = db.BNTXG;
               
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
