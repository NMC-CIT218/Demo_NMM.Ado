using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Demo_NMM.Ado.Models;

namespace Demo_NMM.Ado.Dal
{
    public interface IBreweryRepository
    {
        void Insert(Brewery brewery);
        void Update(Brewery brewery);
        void Delete(int id);
        Brewery SelectOne(int id);
        IEnumerable<Brewery> SelectAll();
    }