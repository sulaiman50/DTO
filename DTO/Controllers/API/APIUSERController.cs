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

        // --------------- Get by Id 

        [ResponseType(typeof(userDTO))]
        public IHttpActionResult GetUser(int id) // Get By Id
        {
            var userR = db.users.Find(id);

            if (userR == null)
            {
                return NotFound();
            }
            var map = pro.GetMapper();
            var result = map.Map<users, userDTO>(userR);

            return Ok(result);
        }

        // --------------- Get List Of Users

        //[ResponseType(typeof(userDTO))]
        //public IEnumerable<userDTO> GetUsers() 
        //{ 
        //    var usersL = db.users.ToList();
        //    var map = pro.GetMapper();
        //    var result = map.Map<List<users>, List<userDTO>>(usersL);
        //    return result;
        //}


        // --------------- Post By Id 

        //[ ResponseType(typeof(userDTO))]
        // [HttpPost]
        // public IHttpActionResult PostUsersDTO(userDTO userDTO)
        // {
        //     var map = pro.GetMapper();
        //     var result1 = map.Map<userDTO, users>(userDTO);
        //     var user = db.users.Where(x => x.Id == result1.Id).FirstOrDefault();
        //     if (user == null)
        //     {
        //         return NotFound();
        //     }
        //     var result = map.Map<users, userDTO>(user);

        //     return Ok(result);
        // }


    }
}
