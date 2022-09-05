using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp60
{
    public class Demo
    {
        private int _id;
        private string _vareNavn;
        private string _vareBeskrivelse;
        private int _pris;



        public int id
        {
            get => id;
            set => id = value;
        }

        public string vareNavn
        {
            get => _vareNavn;   
            set => _vareNavn = value;
        }

        public string vareBeskrivelse
        {
            get => _vareBeskrivelse;
            set => _vareBeskrivelse = value;

        }

        public int pris
        {
            get => _pris;
            set => _pris = value;
        }


        public override string ToString()
        {
            return $"{nameof(_id)}: {_id}, {nameof(_vareNavn)}: {_vareNavn}, {nameof(_vareBeskrivelse)}: {_vareBeskrivelse}
    }


}
