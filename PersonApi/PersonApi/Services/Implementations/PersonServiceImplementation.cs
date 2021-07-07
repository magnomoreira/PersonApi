using PersonApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PersonApi.Services.Implementations
{
	public class PersonServiceImplementation : IPersonService
	{

		private volatile int count;
		public Person Create(Person person)
		{
			return person;
		}

		public void Delete(long id)
		{
			
		}

		public List<Person> FindAll()
		{
			List<Person> persons = new List<Person>();
			for ( int i = 0; i< 8; i++)
			{
				Person person = MockPerson(i);
				persons.Add(person);
			}
			return persons;
		}

		public Person FindById(long id)
		{
			return new Person
			{
				Id = 1,
				FirstName = "Magno",
				LastName = "Moreira",
				Adress = "Japeri , Rio de Janeiro",
				Gender = "Mule"

			};
		}

		public Person Update(Person person)
		{

			return person;
		}
		private Person MockPerson(int i)
		{
			return new Person
			{
				Id = IncrementAndGet(),
				FirstName = "Person Magno" + i,
				LastName = "Person Moreira" + i,
				Adress = "Some Addres" + i,
				Gender = "Male"

			};
		}

		private long IncrementAndGet()
		{
			return Interlocked.Increment(ref count);
		}
	}
}
