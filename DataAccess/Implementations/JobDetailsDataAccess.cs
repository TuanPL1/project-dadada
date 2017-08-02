using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using DataAccess.Data;
using DataAccess.Enum;
using DataAccess.Interfaces;
using DataAccess.MapperRegister;
using DataAccess.Messages.Requests;
using DataAccess.Messages.Responses;
using DataAccess.Models;
using DataAccess.ViewModels;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace DataAccess.Implementations
{
    public class JobDetailsDataAccess : IJobDetailsDataAccess
    {

        private readonly RemovalistContext _context;
        private readonly IMapper _mapper = new DataAccessMapperConfiguration().Configure().CreateMapper();
        public JobDetailsDataAccess(RemovalistContext context)
        {
            _context = context;
        }
        public GetJobDetailsResponse GetJobDetails(GetJobDetailsRequest request)
        {

            using (var context = _context)
            {
                var jobDetails = context.JobDetailses.FirstOrDefault(job => job.JobDetailsId == request.Id);
                if (jobDetails == null)
                {
                    return new GetJobDetailsResponse()
                    {
                        Status = ResultStatus.Fail,
                        Message = "JobId not found"
                    };
                }
                return new GetJobDetailsResponse()
                {
                    JobDetails = _mapper.Map<JobDetails,JobDetailsObject>(jobDetails),
                    Status = ResultStatus.Success
                };
            }


        }

        public CreateJobDetailsReponse CreateJobDetails(CreateJobDetailsRequest request)
        {
            try
            {
                using (var context = _context)
                {
                    var newJob = request.Job;
                    newJob.JobDetailsId = 0;
                    context.JobDetailses.Add(newJob);
                    context.SaveChanges();
                    return new CreateJobDetailsReponse
                    {
                        Id = newJob.JobDetailsId,
                        Status = ResultStatus.Success
                    };
                }
            }
            catch (Exception e)
            {
                return new CreateJobDetailsReponse
                {
                    Status = ResultStatus.Fail,
                    Message = e.Message
                };
            }
        }

        public DeleteJobDetailsResponse DeleteJobDetails(DeleteJobDetailsRequest request)
        {
            try
            {
                using (var context = _context)
                {
                    var newJob = context.JobDetailses.FirstOrDefault(x => x.JobDetailsId == request.Id);
                    context.JobDetailses.Remove(newJob);
                    context.SaveChanges();
                    return new DeleteJobDetailsResponse
                    {
                        Status = ResultStatus.Success
                    };
                }
            }
            catch (Exception e)
            {
                return new DeleteJobDetailsResponse()
                {
                    Status = ResultStatus.Fail,
                    Message = e.Message
                };
            }
        }
    }
}
