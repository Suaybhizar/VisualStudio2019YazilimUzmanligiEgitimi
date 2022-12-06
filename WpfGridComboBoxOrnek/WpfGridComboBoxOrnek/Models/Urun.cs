using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfGridComboBoxOrnek.Models
{
    public class Urun : INotifyPropertyChanged
    {//INotifyPropertyChanged uygulandığı sınıfın UI'nı uyarmaya yapılan değişiklerden haberdar olmasını sağlıyor.
        int id;
        string adi;
        int kategoriId;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }

        public string Adi
        {
            get
            {
                return adi;
            }

            set
            {
                adi = value;
                OnPropertyChanged("Adi");
            }
        }

        public int KategoriId
        {
            get
            {
                return kategoriId;
            }

            set
            {
                kategoriId = value;
                OnPropertyChanged("KategoriId");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propertyName)
        {
            //Burakada ki ? işareti null olablileceğini ifade eder.
            
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
