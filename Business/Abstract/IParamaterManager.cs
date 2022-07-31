using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IParamaterManager
    {
        void Add(Paramaters paramater);
        void Remove(Paramaters paramater);
        void Update(Paramaters paramater);
        List<Paramaters> GetAllParamaters();
        Paramaters GetParamaterById(int id);
    }
}
