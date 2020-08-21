using Antlr.Runtime.Tree;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;
namespace WebApiDemo.Controllers
{
    public class MediaController : ApiController
    {
        public IEnumerable<KTR_MED> Get()
        {
            using (EntrepotKANTARTestEntities entities = new EntrepotKANTARTestEntities())
            {
                return entities.KTR_MED.ToList();
            }
        }

        public KTR_MED GetByID(int id)
        {
            using (EntrepotKANTARTestEntities entities = new EntrepotKANTARTestEntities())
            {
                return entities.KTR_MED.FirstOrDefault(m => m.MED_ID == id);
            }
        }
    }
}
