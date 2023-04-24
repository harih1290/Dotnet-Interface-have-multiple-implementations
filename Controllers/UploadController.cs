using Microsoft.AspNetCore.Mvc;
using runtimeass.Interface;

namespace runtimeass.Controllers{
    [ApiController]
    public class UploadController:ControllerBase{
        private IEnumerable<IDocupload> _idocupload;
        public UploadController(IEnumerable<IDocupload> idocupload){
            _idocupload=idocupload;
        }
        
        [HttpGet]
        [Route("api/Upload/xget")]
        public string xget(string value,string type){
            var helloer = _idocupload.FirstOrDefault(h => h.GetType().Name == type);
            return helloer?.XGet(value);
        }
    }
}