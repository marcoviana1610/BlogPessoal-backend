using BlogPessoal.Model;
using BlogPessoal.Service.TopicService;
using Microsoft.AspNetCore.Mvc;



namespace BlogPessoal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicController : ControllerBase
    {
        private readonly ITopicInterface _topicInterface;
        public TopicController(ITopicInterface topicinterface)
        {
            _topicInterface = topicinterface;


        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<TopicModel>>>> GetAllTopics()
        {
            return Ok(await _topicInterface.GetAllTopics());
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<TopicModel>>>> AddTopic(TopicModel topic)
        {
            return Ok(await _topicInterface.AddTopic(topic));
        }
    }
}
