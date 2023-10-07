using BlogPessoal.Data;
using BlogPessoal.Model;
using Microsoft.EntityFrameworkCore;

namespace BlogPessoal.Service.TopicService
{

    public class TopicService : ITopicInterface
    {

        private readonly ApplicationDbContext _context;

        public TopicService(ApplicationDbContext context)
        {
            _context = context;
        }



        public async Task<ServiceResponse<List<TopicModel>>> AddTopic(TopicModel topic) // FEITO
        {
            ServiceResponse<List<TopicModel>> serviceResponse = new ServiceResponse<List<TopicModel>>();

            try
            {

                if(topic == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Message = "Nenhum dado recebido";
                }

                serviceResponse.Message = "Post recebido com sucesso";
                _context.Add(topic);
                await _context.SaveChangesAsync();



            }catch (Exception ex)
            {
                serviceResponse.Message += ex.ToString();
                serviceResponse.Success = false;
            }

            return serviceResponse;
        }

        public Task<ServiceResponse<List<TopicModel>>> DeleteTopic(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<TopicModel>>> GetAllTopics() // FEITO
        {
            ServiceResponse<List<TopicModel>> serviceResponse = new ServiceResponse<List<TopicModel>>();

            try
            {

                serviceResponse.Dados = _context.topicModels.ToList();


                if (serviceResponse.Dados.Count == 0)
                {
                    serviceResponse.Message = "Nenhum dado foi encontrado";
                }
                else if (serviceResponse.Dados.Count > 0)
                {
                    serviceResponse.Message = "Dados encontrados com sucesso";
                }




            }
            catch (Exception ex)
            {
                serviceResponse.Message = ex.Message;
                serviceResponse.Success = false;
            }


            return serviceResponse;
        } 

        public Task<ServiceResponse<TopicModel>> GetTopicById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<TopicModel>>> UpdateTopic(TopicModel editedTopic)
        {
            throw new NotImplementedException();
        }
    }
}
