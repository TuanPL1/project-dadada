using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Base;
using DataAccess.Enum;
using DataAccess.Models;
using DataAccess.ViewModels;

namespace DataAccess.Messages.Responses
{
    public class GetJobDetailsResponse : ResultBase<ResultStatus>
    {
        public JobDetailsObject JobDetails { get; set; }
    }
}
