using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject;

namespace Dataaccess
{
    public class Udataaccess
    {
        private DependencyEntities dependencyEntities;
        public Udataaccess()
        {
            dependencyEntities = new DependencyEntities();
        }
        public Ucustom useradd(Ubussinessobject ubussinessobject)
        {
            Ucustom ucustom = new Ucustom();
            dependencytable dependencyobj = new dependencytable()
            {
                userid = ubussinessobject.userid,
                userfirstname = ubussinessobject.userfirstname,
                userlastname = ubussinessobject.userlastname,
                useraddress = ubussinessobject.useraddress,
                useremail = ubussinessobject.useremail

            };
            dependencyEntities.dependencytables.Add(dependencyobj);
             int value = dependencyEntities.SaveChanges();
            if (value > 0)
            {
                ucustom.mess = "success";
                ucustom.messnum = value;

            }
            else
            {
                ucustom.mess = "not successfull";
                ucustom.messnum = value;
            }
            return ucustom;

        }
    }
}
