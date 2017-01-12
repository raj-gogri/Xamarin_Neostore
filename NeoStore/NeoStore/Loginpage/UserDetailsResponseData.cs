using NeoStore.HomePage;
using Newtonsoft.Json;
using SQLite;
using System;

namespace NeoStore.Loginpage
{
    [Table("User")]
    public class UserDetailsResponseData
    {
            [PrimaryKey]
            public int id { get; set; }

            [JsonProperty(PropertyName = "role_id")]
            public int RoleId { get; set; }

            [JsonProperty(PropertyName = "first_name")]
            public string FirstName { get; set; }

            [JsonProperty(PropertyName = "last_name")]
            public string LastName { get; set; }

            [JsonProperty(PropertyName = "email")]
            public string Email { get; set; }

            [JsonProperty(PropertyName = "username")]
            public string UserName { get; set; }

            [JsonProperty(PropertyName = "profile_pic")]
            public string ProfilePic { get; set; }

            [JsonProperty(PropertyName = "country_id")]
            public string CountryId { get; set; }

            [JsonProperty(PropertyName = "gender")]
            public string Gender { get; set; }

            [JsonProperty(PropertyName = "phone_no")]
            public int PhoneNo { get; set; }

            [JsonProperty(PropertyName = "dob")]
            public string DoB { get; set; }

            [JsonProperty(PropertyName = "is_active")]
            public Boolean IsActive { get; set; }

            [JsonProperty(PropertyName = "created")]
            public DateTime Created { get; set; }

            [JsonProperty(PropertyName = "modified")]
            public DateTime Modified { get; set; }

            [JsonProperty(PropertyName = "access_token")]
            public string AccessToken { get; set; }
            

    }
    }
