using System;
using System.Collections.Generic;
using System.Text;

namespace BA.Demo.Encapsulation
{
    public class Identification             // changer class en struct, et inversément, pour voir la différence
    {
        public Guid Identifieur { get; private set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string NomComplet { get { return $"{Nom} {Prenom}"; } }

        private string _email;
        private string _motDePasse;


        public string Email
        {
            get { return _email; }
            set
            {
                if (value.Contains('@')) _email = value;
            }
        }

        #region Des méthodes peuvent aisément remplacer les propriétés, mais mauvaises pratiques
        //public string GetEmail()
        //{
        //    return _email;
        //}

        //public void SetEmail(string value)
        //{
        //    if (value.Contains('@')) _email = value;
        //}
        #endregion

        public string MotDePasse
        {
            //private get { return _motDePasse; }
            set { _motDePasse = value; }
        }

        public bool IsOk()
        {
            string DBUserName = "sam@fait.rire";
            string DBPwd = "Test1234=";
            return Email == DBUserName && _motDePasse == DBPwd;
            //return Email == DBUserName && MotDePasse == DBPwd; // Notre propriété MotDePasse n'est accessible que si private get
        }
    }
}
