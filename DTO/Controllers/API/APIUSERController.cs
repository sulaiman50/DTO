using DTO.DTO;
using DTO.Mapconn;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace DTO.Controllers.API
{
    public class APIUSERController : ApiController
    {
         MoviesDBEntities db = new MoviesDBEntities();
        private MapProile pro = new MapProile(); 

        //[ResponseType(typeof(userDTO))]
        //public IHttpActionResult GetUser(int id )
        //{
        //    var userR = db.users.Find(id);

        //    if(userR == null )
        //    {
        //        return NotFound();
        //    }
        //    var map = pro.GetMapper();
        //    var result = map.Map<users,user_DTO>(userR);

        //    return Ok(result);
        //}

        [ResponseType(typeof(userDTO))]
        public IEnumerable<userDTO> GetUsers() 
        { 
        
            var usersL = db.users.ToList();
            var map = pro.GetMapper();
            var result = map.Map<List<users>, List<userDTO>>(usersL);
            return result;


        }


    }
}
