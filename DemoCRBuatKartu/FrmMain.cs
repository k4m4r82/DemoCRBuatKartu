using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DemoCRBuatKartu.Model;
using DemoCRBuatKartu.CR;

namespace DemoCRBuatKartu
{
    public partial class FrmMain : Form
    {
        private IList<Siswa> recordSiswa;

        public FrmMain()
        {
            InitializeComponent();

            LoadDataSiswa();
            ShowKartuSiswa();
        }

        private void LoadDataSiswa()
        {
            recordSiswa = new List<Siswa>();
            recordSiswa.Add(new Siswa { Nis = "10.02.7659", Nama = "HARDIYAH WAHYUDI", Alamat = "Yogyakarta" });
            recordSiswa.Add(new Siswa { Nis = "10.02.7665", Nama = "MUHAMMAD TAUFIQ HIDAYAH", Alamat = "Kalimantan" });
            recordSiswa.Add(new Siswa { Nis = "10.02.7705", Nama = "RAHMAT ABDUL WAKID", Alamat = "Riau" });
            recordSiswa.Add(new Siswa { Nis = "10.02.7732", Nama = "RINA PRATAMA SARI", Alamat = "Yogyakarta" });
            recordSiswa.Add(new Siswa { Nis = "10.02.7744", Nama = "VEGA ERIDANUS HARTANTO", Alamat = "Yogyakarta" });
            recordSiswa.Add(new Siswa { Nis = "10.02.7745", Nama = "BAGUS ARI NUGROHO", Alamat = "Yogyakarta" });
            recordSiswa.Add(new Siswa { Nis = "10.02.7746", Nama = "DONI DWITAMA SAKTI", Alamat = "Yogyakarta" });
            recordSiswa.Add(new Siswa { Nis = "10.02.7747", Nama = "IRAWATI KELANOHON", Alamat = "Yogyakarta" });
            recordSiswa.Add(new Siswa { Nis = "10.02.7748", Nama = "VINA HESTI NILASARI", Alamat = "Yogyakarta" });
            recordSiswa.Add(new Siswa { Nis = "10.02.7749", Nama = "FAUZAN ROSADI SUDIRJA", Alamat = "Yogyakarta" });
        }

        private void ShowKartuSiswa()
        {
            var reportBarang = new CRKartuSiswa();
            reportBarang.Database.Tables["Siswa"].SetDataSource(recordSiswa);

            crViewer.ReportSource = reportBarang;
        }
    }
}
