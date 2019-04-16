using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    public class Akun  //Tambahkan IIdentitas,ITransaksi di LAB 3.4
    {
        private const int maxSaldo = 2000000;
        private int _saldo; //protected untuk LAB 3.3
        protected string password;

        //LAB 3.4
        //public int Id { get; set; }
        //public string Password
        //{
        //    get
        //    {
        //        return password;
        //    }
        //    set
        //    {
        //        if (value.Length > 8)
        //            password = value;
        //        else
        //            throw new InvalidOperationException("Password harus lebih dari 8 karakter");
        //    }
        //}

        public int Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                    throw new InvalidOperationException("Saldo tidak bisa kurang dari 0 rupiah");
                else if (value > maxSaldo) //untuk LAB 3.3, tidak ada maxSaldo
                    throw new InvalidOperationException("Saldo tidak boleh melebihi 2000000 rupiah");
                else
                    _saldo = value;
            }
        }

        public Akun(/*int id, LAB 3.4*/int saldo, string password)
        {
            // Id = id;
            _saldo = saldo;
            this.password = password; //Password = password; LAB 3.4
        }
        // Tambahkan virtual pada meethod Setor() dan Tarik() di LAB 3.3, dan Saldo += jumlah+500 Saldo -= jumlah+500, LAB 3.4 juga virtual
        public void Setor(int jumlah)
        {
            Saldo += jumlah;
        }

        public void Tarik(int jumlah)
        {
            Saldo -= jumlah;
        }
        public bool PasswordTervalidasi(string password)
        {
            if (this.password == password)
                return true;
            else
                return false;
        }
    }
}