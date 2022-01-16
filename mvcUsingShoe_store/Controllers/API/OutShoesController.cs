using mvcUsingShoe_store.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace mvcUsingShoe_store.Controllers.API
{
    public class OutShoesController : ApiController

    {
        ShoesStoreDbContext dbContext = new ShoesStoreDbContext();
        // GET: api/OutShoes
        public IHttpActionResult Get()
        {
            try
            {
                List<OutShoes> Shoes = dbContext.OutShoes.ToList();
                return Ok(new { Shoes });
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

        // GET: api/OutShoes/5
        public async Task<IHttpActionResult> Get(int id)
        {
            try
            {
                OutShoes outShoeById =await dbContext.OutShoes.FindAsync(id);
                return Ok(new { outShoeById });
            }
            catch(SqlException ex)
            {
                return NotFound();
            }
            catch(Exception ex)
            {
                return NotFound();
            }
            }

        // POST: api/OutShoes
            public async Task<IHttpActionResult> Post([FromBody] OutShoes outShoes)
            {
                try
                {
                    dbContext.OutShoes.Add(outShoes);
                   await dbContext.SaveChangesAsync();
                    List<OutShoes> Shoes = dbContext.OutShoes.ToList();
                    return Ok(new { Shoes });
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

            // PUT: api/OutShoes/5
            public async Task<IHttpActionResult> Put(int id, [FromBody] OutShoes outShoes)
            {
                try
                {
                    OutShoes outShoeToChange =await dbContext.OutShoes.FindAsync(id);
                    outShoeToChange.Name = outShoes.Name;
                    outShoeToChange.HasDue = outShoes.HasDue;
                    outShoeToChange.HasInStock = outShoes.HasInStock;
                    outShoeToChange.Price = outShoes.Price;
                   await dbContext.SaveChangesAsync();
                    List<OutShoes> Shoes = dbContext.OutShoes.ToList();
                    return Ok(new { Shoes });
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

            // DELETE: api/OutShoes/5
            public async Task<IHttpActionResult> Delete(int id)
            {
                try
                {
                    OutShoes outShoesToDelete =await dbContext.OutShoes.FindAsync(id);
                    dbContext.OutShoes.Remove(outShoesToDelete);
                    await dbContext.SaveChangesAsync();
                    List<OutShoes> Shoes = dbContext.OutShoes.ToList();
                    return Ok(new { Shoes });
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
