using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject;
using Dataaccess;

namespace BussinessLogic
{
    public class  Userbl:IUserbl
    {
        public Ucustom useradd(Ubussinessobject ubussinessobject)
        {
            return new Udataaccess().useradd(ubussinessobject);

        }
    }
}
