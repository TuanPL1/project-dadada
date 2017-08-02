using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Data;
using DataAccess.Enum;
using DataAccess.Implementations;
using DataAccess.Interfaces;
using DataAccess.Messages.Requests;
using DataAccess.Messages.Responses;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace RemovalistAPI.Controllers
{
    [Route("api/[controller]")]
    public class JobDetailsController : Controller
    {
        private IJobDetailsDataAccess _dataAccess;
        public JobDetailsController(IJobDetailsDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }



        // GET api/valuess

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return JsonConvert.SerializeObject(_dataAccess.GetJobDetails(new GetJobDetailsRequest(){Id=id}));
        }

        // POST api/values
        [HttpPost]
        public string Post([FromBody]JobDetails job)
        {
            
            try
            {
                if (job == null) throw new ArgumentNullException(nameof(job));
                return JsonConvert.SerializeObject(
                    _dataAccess.CreateJobDetails(new CreateJobDetailsRequest() {Job = job }));
            }
            catch (Exception e)
            {
                return JsonConvert.SerializeObject(
                    new CreateJobDetailsReponse() {Status = ResultStatus.Fail, Message = e.Message});
            }
        }

        [HttpPost("DeleteJobDetails")]
        public string DeleteJobDetails([FromBody] int id)
        {
            try
            {
                if (id == 0)
                    return JsonConvert.SerializeObject(
                    new DeleteJobDetailsResponse() { Status = ResultStatus.Fail, Message = "Id not valid" }); ;
                return JsonConvert.SerializeObject(
                    _dataAccess.DeleteJobDetails(new DeleteJobDetailsRequest() { Id = id }));
            }
            catch (Exception e)
            {
                return JsonConvert.SerializeObject(
                    new DeleteJobDetailsResponse() { Status = ResultStatus.Fail, Message = e.Message });
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
