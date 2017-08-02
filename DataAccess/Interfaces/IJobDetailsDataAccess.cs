using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Messages.Requests;
using DataAccess.Messages.Responses;

namespace DataAccess.Interfaces
{
    public interface IJobDetailsDataAccess
    {
        GetJobDetailsResponse GetJobDetails(GetJobDetailsRequest request);
        CreateJobDetailsReponse CreateJobDetails(CreateJobDetailsRequest request);
        DeleteJobDetailsResponse DeleteJobDetails(DeleteJobDetailsRequest request);
    }
}
