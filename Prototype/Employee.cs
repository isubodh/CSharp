using Newtonsoft.Json;

namespace prototype {

    public abstract class Person {
        public abstract string Name {get; set; }
        public abstract Person Clone(bool isDeepClone);
    }

    public class  Employee  : Person {
        public override string Name { get; set; }
        public Manager Manager {get; set; }
        public Employee(string name, Manager manager){
            Name = name;
            Manager = manager;
        }

        public override Person Clone(bool isDeepClone = false){
            if (isDeepClone){
                var settings = new JsonSerializerSettings {TypeNameHandling = TypeNameHandling.All};
                var JsonObject = JsonConvert.SerializeObject(this, typeof(Employee), settings);
                 return JsonConvert.DeserializeObject<Person>(JsonObject, settings);
            } 
                return (Person)MemberwiseClone();
            
        }
    }
    public class Manager : Person
    {
        public override string Name { get; set; }

        public Manager(string name){
            Name = name;
        }
        public override Person Clone(bool isDeepClone = false){
         if (isDeepClone){
                var settings = new JsonSerializerSettings {TypeNameHandling = TypeNameHandling.All};
                var JsonObject = JsonConvert.SerializeObject(this, typeof(Manager), settings);
                 return JsonConvert.DeserializeObject<Person>(JsonObject, settings);
            }
            return (Person)MemberwiseClone();
            
        }
    }
}
