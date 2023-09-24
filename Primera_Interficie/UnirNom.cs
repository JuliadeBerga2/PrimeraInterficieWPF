using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primera_Interficie
{
    public class UnirNom : INotifyPropertyChanged
    {
        private string nom, cognom, nom_complet;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public string Nom 
        { 
            get { return nom; }

            set { nom = value;

                OnPropertyChanged("Nom_Complet");
            
            }
        }


        public string Cognom
        {
            get { return cognom; }

            set { cognom = value;

                OnPropertyChanged("Nom_Complet");

            }
        }


        public string Nom_Complet
        {
            get { nom_complet = Nom + " " + Cognom;

                return nom_complet; 
            }

            set { cognom = value; }
        }

    }
}
