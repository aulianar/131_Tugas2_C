using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().InsertData();
        }

        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source = AULIANA\\AULIANA;database=TOKOROTI;User ID=sa;Password=Anata1133");
                con.Open();

                SqlCommand cm = new SqlCommand(
                "Insert into Pembeli (Id_Pembeli, Nama_Pembeli, Alamat, No_HP) values ('0001', 'Jake', 'Seoul', '1234567890')" +
                "Insert into Pembeli (Id_Pembeli, Nama_Pembeli, Alamat, No_HP) values ('0002', 'Sunghoon', 'Seoul', '1234567891')" +
                "Insert into Pembeli (Id_Pembeli, Nama_Pembeli, Alamat, No_HP) values ('0003', 'Heeseung', 'Seoul', '1234567892')"+
                "Insert into Pembeli (Id_Pembeli, Nama_Pembeli, Alamat, No_HP) values ('0004', 'Jay', 'Seoul', '1234567893')" +
                "Insert into Pembeli (Id_Pembeli, Nama_Pembeli, Alamat, No_HP) values ('0005', 'Ni-ki', 'Seoul', '1234567894')"+

                "Insert into Barang (Id_Barang, Nama_Barang, Harga) values ('1111', 'Black Forest Cake', '25.000')"+
                "Insert into Barang (Id_Barang, Nama_Barang, Harga) values ('1112', 'Cheese Cake ', '23.000')" +
                "Insert into Barang (Id_Barang, Nama_Barang, Harga) values ('1113', 'Chiffon Cake', '27.000')"+
                "Insert into Barang (Id_Barang, Nama_Barang, Harga) values ('1114', 'Red Velvet Cake', '25.000')"+
                "Insert into Barang (Id_Barang, Nama_Barang, Harga) values ('1115', 'Biscuit Cake', '22.000')"+

                "Insert into Pegawai (Id_Pegawai, Nama_Pegawai) values ('1122', 'Yeonjun')"+
                "Insert into Pegawai (Id_Pegawai, Nama_Pegawai) values ('1123', 'Beomgyu')"+
                "Insert into Pegawai (Id_Pegawai, Nama_Pegawai) values ('1124', 'Soobin')"+
                "Insert into Pegawai (Id_Pegawai, Nama_Pegawai) values ('1125', 'Taehyun')"+
                "Insert into Pegawai (Id_Pegawai, Nama_Pegawai) values ('1126', 'Kai')"+

                "Insert into Transaksi (Id_Transaksi, Tanggal, Qty, Jumlah_Harga, Id_Barang, Id_Pegawai, Id_Pembeli) values ('01', '260322', '2', '50.000', '1111', '1122', '0001')"+
                "Insert into Transaksi (Id_Transaksi, Tanggal, Qty, Jumlah_Harga, Id_Barang, Id_Pegawai, Id_Pembeli) values ('02', '260322', '2', '46.000', '1112', '1123', '0002')"+
                "Insert into Transaksi (Id_Transaksi, Tanggal, Qty, Jumlah_Harga, Id_Barang, Id_Pegawai, Id_Pembeli) values ('03', '260322', '2', '54.000', '1113', '1124', '0003')"+
                "Insert into Transaksi (Id_Transaksi, Tanggal, Qty, Jumlah_Harga, Id_Barang, Id_Pegawai, Id_Pembeli) values ('04', '260322', '2', '50.000', '1114', '1125', '0004')"+
                "Insert into Transaksi (Id_Transaksi, Tanggal, Qty, Jumlah_Harga, Id_Barang, Id_Pegawai, Id_Pembeli) values ('05', '260322', '2', '44.000', '1115', '1125', '0005')", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses Menambahkan Data");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal Menambahkan Data " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
