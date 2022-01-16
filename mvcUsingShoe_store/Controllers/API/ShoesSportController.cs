using mvcUsingShoe_store.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace mvcUsingShoe_store.Controllers.API
{
    public class ShoesSportController : ApiController
    {
        DezinerShoesSportDataContext dataContext = new DezinerShoesSportDataContext();

        // GET: api/ShoesSport
        public IHttpActionResult Get()
        {
            try
            {
                List<ShoesSportTable> shoes = dataContext.ShoesSportTables.ToList();
                return Ok(new { shoes });
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/ShoesSport/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                ShoesSportTable shoesSport = dataContext.ShoesSportTables.First(item => item.Id == id);
                return Ok(new { shoesSport });
            }
            catch (SqlException ex)
            {
                return NotFound();
            }
            catch (Exception ex)
            {
                return NotFound();
            }

        }

        // POST: api/ShoesSport
        public IHttpActionResult Post([FromBody] ShoesSportTable Shoes)
        {
            try
            {
                dataContext.ShoesSportTables.InsertOnSubmit(Shoes);
                dataContext.SubmitChanges();
                List<ShoesSportTable> shoes = dataContext.ShoesSportTables.ToList();
                return Ok(new { shoes });
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/ShoesSport/5
        public IHttpActionResult Put(int id, [FromBody] ShoesSportTable Shoes)
        {
            try
            {
                ShoesSportTable shoesSportToChange = dataContext.ShoesSportTables.First(item => item.Id == id);
                shoesSportToChange.name = Shoes.name;
                shoesSportToChange.size = Shoes.size;
                shoesSportToChange.model = Shoes.model;
                dataContext.SubmitChanges();
                return Ok("you UpDate One");
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/ShoesSport/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                ShoesSportTable shoesSportToDelete = dataContext.ShoesSportTables.First(item => item.Id == id);
                dataContext.ShoesSportTables.DeleteOnSubmit(shoesSportToDelete);
                dataContext.SubmitChanges();
                return Ok("you delete");
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
