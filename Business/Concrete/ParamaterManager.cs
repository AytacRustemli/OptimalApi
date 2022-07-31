using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ParamaterManager : IParamaterManager
    {
        private readonly IParamaterDal _paramaterDal;

        public ParamaterManager(IParamaterDal paramaterDal)
        {
            _paramaterDal = paramaterDal;
        }

        public void Add(Paramaters paramater)
        {
           _paramaterDal.Add(paramater);
        }

        public List<Paramaters> GetAllParamaters()
        {
            return _paramaterDal.GetAll();
        }

        public Paramaters GetParamaterById(int id)
        {
            return _paramaterDal.Get(x => x.Id == id);
        }

        public void Remove(Paramaters paramater)
        {
            _paramaterDal.Delete(paramater);
        }

        public void Update(Paramaters paramater)
        {
            _paramaterDal.Update(paramater);
        }
    }
}
