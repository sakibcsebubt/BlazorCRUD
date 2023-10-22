using System.Text.Json.Serialization;

namespace BlazorCRUDApp.Model
{

    public class EmployeeModel
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("empName")]
        public string EmpName { get; set; }
        [JsonPropertyName("empCode")]
        public string EmpCode { get; set; }
        [JsonPropertyName("designation")]
        public string? Designation { get; set; }
        [JsonPropertyName("address")]
        public string? Address { get; set; }
        [JsonPropertyName("salary_Grade")]
        public string Salary_Grade { get; set; }
    }
    public class EmployeeModel1
    {
        //[JsonPropertyName("id")]
        public long id { get; set; }
        //[JsonPropertyName("empName")]
        public string empName { get; set; }
        //[JsonPropertyName("empCode")]
       // public string EmpCode { get; set; }
       ///// <summary>
       ///// [JsonPropertyName("designation")]
       ///// </summary>
       // public string? Designation { get; set; }
       //// [JsonPropertyName("address")]
       // public string? Address { get; set; }
       // //[JsonPropertyName("salary_Grade")]
       // public string Salary_Grade { get; set; }
    }
}
