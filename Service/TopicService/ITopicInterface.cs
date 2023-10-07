using BlogPessoal.Model;

namespace BlogPessoal.Service.TopicService
{
    public interface ITopicInterface
    {
        Task<ServiceResponse<List<TopicModel>>> GetAllTopics();
        Task<ServiceResponse<TopicModel>> GetTopicById(int id);
        Task<ServiceResponse<List<TopicModel>>> AddTopic(TopicModel topic);
        Task<ServiceResponse<List<TopicModel>>> DeleteTopic(int id);
        Task<ServiceResponse<List<TopicModel>>> UpdateTopic(TopicModel editedTopic);

    }
}
