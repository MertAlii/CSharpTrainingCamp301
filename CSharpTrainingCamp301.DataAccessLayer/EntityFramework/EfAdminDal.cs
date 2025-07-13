using CSharpTrainingCamp301.DataAccessLayer.Repositories;
using CSharpTrainingCamp301.DataAccessLayer.Abstract;
using CSharpTrainingCamp301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTrainingCamp301.DataAccessLayer.EntityFramework
{
    public class EfAdminDal : GenericRepository<Admin>, IAdminDal
    {

    }
}
