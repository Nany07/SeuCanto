using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeuCanto
{
    class Session
    {
        private static volatile Session instance;
        private static object sync = new Object();

        private Session() { }

        public static Session Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (sync)
                    {
                        if (instance == null)
                        {
                            instance = new Session();
                        }
                    }
                }
                return instance;
            }

        }

        /// <summary>
        /// Propriedade para o ID do usuario
        /// </summary>
        public int UserID { get; set; }

        /*Como usar!!!
         
        Para ajustar o ID do usuário, bastaria fazer algo do tipo:

        Session.Instance.UserID = 10;
        Pare recuperar:

        int ID = Session.Instance.UserID;
        */
    }
}
