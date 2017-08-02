using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DataAccess.Messages.Requests
{
    public class CreateJobDetailsRequest
    {
        public JobDetails Job { get; set; }
    }
}
