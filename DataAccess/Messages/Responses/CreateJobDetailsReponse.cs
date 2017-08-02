using DataAccess.Base;
using DataAccess.Enum;

namespace DataAccess.Messages.Responses
{
    public class CreateJobDetailsReponse: ResultBase<ResultStatus>
    {
        public int Id { get; set; }
    }
}