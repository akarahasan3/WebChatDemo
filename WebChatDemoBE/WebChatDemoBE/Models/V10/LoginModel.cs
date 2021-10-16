using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace WebChatDemoBE.Models
{
    [DataContract]
    public class LoginModel
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [DataMember(Name = "username")]
        public string Username { get; set; }
        
        [Required]
        [DataMember(Name = "password")]
        public string Password { get; set; }
    }
}