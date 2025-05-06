using EventEase.Models;

public class EventService
{
    private readonly List<UserModel> mockUsers = new List<UserModel>
    {
        new UserModel { Name = "Alice Johnson", Email = "alice.johnson@example.com" },
        new UserModel { Name = "Bob Smith", Email = "bob.smith@example.com" },
        new UserModel { Name = "Charlie Brown", Email = "charlie.brown@example.com" },
        new UserModel { Name = "Diana Prince", Email = "diana.prince@example.com" },
        new UserModel { Name = "Eve Adams", Email = "eve.adams@example.com" }
    };

    public List<EventModel> Events { get; private set; }

    public EventService()
    {
        // Initialize mock events with CreatedBy and Attendees
        Events = new List<EventModel>
        {
            new EventModel
            {
                Id = 1,
                Name = "Corporate Retreat",
                StartDate = new DateTime(2025, 11, 15, 9, 0, 0),
                EndDate = new DateTime(2025, 11, 17, 17, 0, 0),
                Location = "London",
                Description = "A weekend retreat for team building and relaxation.",
                CreatedBy = mockUsers[0],
                Attendees = new List<UserModel> { mockUsers[1], mockUsers[2] }
            },
            new EventModel
            {
                Id = 2,
                Name = "Annual Gala",
                StartDate = new DateTime(2025, 12, 10, 18, 0, 0),
                EndDate = new DateTime(2025, 12, 10, 23, 0, 0),
                Location = "Paris",
                Description = "A formal event to celebrate our achievements.",
                CreatedBy = mockUsers[1],
                Attendees = new List<UserModel> { mockUsers[0], mockUsers[3] }
            },
            new EventModel
            {
                Id = 3,
                Name = "Tech Conference",
                StartDate = new DateTime(2025, 01, 20, 9, 0, 0),
                EndDate = new DateTime(2025, 01, 22, 17, 0, 0),
                Location = "Berlin",
                Description = "A conference to discuss the latest trends in technology.",
                CreatedBy = mockUsers[2],
                Attendees = new List<UserModel> { mockUsers[3], mockUsers[4] }
            },
            new EventModel
            {
                Id = 4,
                Name = "Startup Pitch Night",
                StartDate = new DateTime(2025, 02, 15, 18, 0, 0),
                EndDate = new DateTime(2025, 02, 15, 22, 0, 0),
                Location = "Amsterdam",
                Description = "An event for startups to pitch their ideas to investors.",
                CreatedBy = mockUsers[3],
                Attendees = new List<UserModel> { mockUsers[0], mockUsers[4] }
            },
            new EventModel
            {
                Id = 5,
                Name = "Music Festival",
                StartDate = new DateTime(2025, 03, 10, 12, 0, 0),
                EndDate = new DateTime(2025, 03, 12, 23, 0, 0),
                Location = "Barcelona",
                Description = "A weekend of music and fun with various artists.",
                CreatedBy = mockUsers[4],
                Attendees = new List<UserModel> { mockUsers[1], mockUsers[2] }
            },
            new EventModel
            {
                Id = 6,
                Name = "Art Exhibition",
                StartDate = new DateTime(2025, 04, 05, 10, 0, 0),
                EndDate = new DateTime(2025, 04, 07, 18, 0, 0),
                Location = "Rome",
                Description = "An exhibition showcasing contemporary art.",
                CreatedBy = mockUsers[0],
                Attendees = new List<UserModel> { mockUsers[2], mockUsers[3] }
            },
            new EventModel
            {
                Id = 7,
                Name = "Food Truck Rally",
                StartDate = new DateTime(2025, 05, 20, 11, 0, 0),
                EndDate = new DateTime(2025, 05, 20, 21, 0, 0),
                Location = "Prague",
                Description = "A gathering of food trucks offering various cuisines.",
                CreatedBy = mockUsers[1],
                Attendees = new List<UserModel> { mockUsers[0], mockUsers[4] }
            },
            new EventModel
            {
                Id = 8,
                Name = "Charity Run",
                StartDate = new DateTime(2025, 06, 15, 8, 0, 0),    
                EndDate = new DateTime(2025, 06, 15, 12, 0, 0),
                Location = "Vienna",
                Description = "A run to raise funds for local charities.",
                CreatedBy = mockUsers[2],
                Attendees = new List<UserModel> { mockUsers[3], mockUsers[4] }
            },
            new EventModel
            {
                Id = 9,
                Name = "Book Fair",
                StartDate = new DateTime(2025, 07, 10, 10, 0, 0),
                EndDate = new DateTime(2025, 07, 12, 18, 0, 0),
                Location = "Dublin",
                Description = "A fair celebrating literature and authors.",
                CreatedBy = mockUsers[3],
                Attendees = new List<UserModel> { mockUsers[0], mockUsers[1] }
            },
            new EventModel
            {
                Id = 10,
                Name = "Film Screening",
                StartDate = new DateTime(2025, 08, 25, 19, 0, 0),
                EndDate = new DateTime(2025, 08, 25, 22, 0, 0),
                Location = "Copenhagen",
                Description = "A screening of independent films.",
                CreatedBy = mockUsers[4],
                Attendees = new List<UserModel> { mockUsers[2], mockUsers[3] }
            },
            new EventModel
            {
                Id = 11,
                Name = "Tech Meetup",
                StartDate = new DateTime(2025, 09, 15, 18, 0, 0),
                EndDate = new DateTime(2025, 09, 15, 21, 0, 0),
                Location = "Stockholm",
                Description = "A meetup for tech enthusiasts to network and share ideas.",
                CreatedBy = mockUsers[0],
                Attendees = new List<UserModel> { mockUsers[1], mockUsers[4] }
            },
            new EventModel
            {
                Id = 12,
                Name = "Gaming Convention",
                StartDate = new DateTime(2025, 10, 20, 10, 0, 0),
                EndDate = new DateTime(2025, 10, 22, 18, 0, 0),
                Location = "Helsinki",
                Description = "A convention for gamers to meet and play.",
                CreatedBy = mockUsers[1],
                Attendees = new List<UserModel> { mockUsers[0], mockUsers[3] }
            },
            new EventModel
            {
                Id = 13,
                Name = "Wine Tasting",
                StartDate = new DateTime(2025, 11, 05, 17, 0, 0),
                EndDate = new DateTime(2025, 11, 05, 20, 0, 0),
                Location = "Bordeaux",
                Description = "A tasting event featuring local wines.",
                CreatedBy = mockUsers[2],
                Attendees = new List<UserModel> { mockUsers[3], mockUsers[4] }
            },
            new EventModel
            {
                Id = 14,
                Name = "Yoga Retreat",
                StartDate = new DateTime(2025, 12, 15, 9, 0, 0),
                EndDate = new DateTime(2025, 12, 17, 17, 0, 0),
                Location = "Santorini",
                Description = "A retreat focused on relaxation and mindfulness.",
                CreatedBy = mockUsers[3],
                Attendees = new List<UserModel> { mockUsers[0], mockUsers[4] }
            },     
            new EventModel
            {
                Id = 15,
                Name = "Photography Workshop",
                StartDate = new DateTime(2025, 01, 15, 10, 0, 0),
                EndDate = new DateTime(2025, 01, 15, 16, 0, 0),
                Location = "Lisbon",
                Description = "A workshop to improve photography skills.",
                CreatedBy = mockUsers[4],
                Attendees = new List<UserModel> { mockUsers[1], mockUsers[2] }
            },
            new EventModel
            {
                Id = 16,
                Name = "Cooking Class",
                StartDate = new DateTime(2025, 02, 10, 18, 0, 0),
                EndDate = new DateTime(2025, 02, 10, 21, 0, 0),
                Location = "Madrid",
                Description = "A class to learn new cooking techniques.",
                CreatedBy = mockUsers[0],
                Attendees = new List<UserModel> { mockUsers[3], mockUsers[4] }
            },
            new EventModel
            {
                Id = 17,
                Name = "Dance Workshop",
                StartDate = new DateTime(2025, 03, 15, 14, 0, 0),
                EndDate = new DateTime(2025, 03, 15, 18, 0, 0),
                Location = "Berlin",
                Description = "A workshop to learn various dance styles.",
                CreatedBy = mockUsers[1],
                Attendees = new List<UserModel> { mockUsers[0], mockUsers[2] }
            },
            new EventModel
            {
                Id = 18,
                Name = "Outdoor Adventure",
                StartDate = new DateTime(2025, 04, 20, 8, 0, 0),
                EndDate = new DateTime(2025, 04, 20, 17, 0, 0),
                Location = "Zurich",
                Description = "An adventure event with hiking and outdoor activities.",
                CreatedBy = mockUsers[2],
                Attendees = new List<UserModel> { mockUsers[3], mockUsers[4] }
            },
            new EventModel
            {
                Id = 19,
                Name = "Virtual Reality Experience",
                StartDate = new DateTime(2025, 05, 25, 10, 0, 0),
                EndDate = new DateTime(2025, 05, 25, 16, 0, 0),
                Location = "Amsterdam",
                Description = "An event showcasing the latest in virtual reality technology.",
                CreatedBy = mockUsers[3],
                Attendees = new List<UserModel> { mockUsers[0], mockUsers[1] }
            },
            new EventModel
            {
                Id = 20,
                Name = "Sustainable Living Workshop",
                StartDate = new DateTime(2025, 06, 30, 9, 0, 0),
                EndDate = new DateTime(2025, 06, 30, 17, 0, 0),
                Location = "Oslo",
                Description = "A workshop focused on sustainable living practices.",
                CreatedBy = mockUsers[4],
                Attendees = new List<UserModel> { mockUsers[2], mockUsers[3] }
            },
            new EventModel
            {
                Id = 21,
                Name = "Blockchain Seminar",
                StartDate = new DateTime(2025, 07, 15, 10, 0, 0),
                EndDate = new DateTime(2025, 07, 15, 16, 0, 0),
                Location = "Tallinn",
                Description = "A seminar discussing the future of blockchain technology.",
                CreatedBy = mockUsers[0],
                Attendees = new List<UserModel> { mockUsers[1], mockUsers[4] }
            },
            new EventModel
            {
                Id = 22,
                Name = "AI and Machine Learning Conference",
                StartDate = new DateTime(2025, 08, 20, 9, 0, 0),
                EndDate = new DateTime(2025, 08, 20, 17, 0, 0),
                Location = "Helsinki",
                Description = "A conference exploring the latest advancements in AI.",
                CreatedBy = mockUsers[1],
                Attendees = new List<UserModel> { mockUsers[0], mockUsers[3] }
            },
            new EventModel
            {
                Id = 23,
                Name = "Digital Marketing Summit",
                StartDate = new DateTime(2025, 09, 25, 10, 0, 0),
                EndDate = new DateTime(2025, 09, 25, 17, 0, 0),
                Location = "Brussels",
                Description = "A summit focusing on digital marketing strategies.",
                CreatedBy = mockUsers[2],
                Attendees = new List<UserModel> { mockUsers[3], mockUsers[4] }
            },
            new EventModel
            {
                Id = 24,
                Name = "Cybersecurity Workshop",
                StartDate = new DateTime(2025, 10, 30, 9, 0, 0),
                EndDate = new DateTime(2025, 10, 30, 17, 0, 0),
                Location = "Vienna",
                Description = "A workshop on the latest cybersecurity practices.",
                CreatedBy = mockUsers[3],
                Attendees = new List<UserModel> { mockUsers[0], mockUsers[1] }
            },
            new EventModel
            {
                Id = 25,
                Name = "E-commerce Expo",
                StartDate = new DateTime(2025, 11, 05, 10, 0, 0),
                EndDate = new DateTime(2025, 11, 05, 17, 0, 0),
                Location = "Amsterdam",
                Description = "An expo showcasing the latest in e-commerce technology.",
                CreatedBy = mockUsers[4],
                Attendees = new List<UserModel> { mockUsers[2], mockUsers[3] }
            },
            new EventModel
            {
                Id = 26,
                Name = "Social Media Marketing Workshop",
                StartDate = new DateTime(2025, 12, 10, 9, 0, 0),
                EndDate = new DateTime(2025, 12, 10, 17, 0, 0),
                Location = "Barcelona",
                Description = "A workshop on effective social media marketing strategies.",
                CreatedBy = mockUsers[0],
                Attendees = new List<UserModel> { mockUsers[1], mockUsers[4] }
            },
            new EventModel
            {
                Id = 27,
                Name = "Content Creation Bootcamp",
                StartDate = new DateTime(2025, 01, 10, 10, 0, 0),
                EndDate = new DateTime(2025, 01, 10, 16, 0, 0),
                Location = "Madrid",
                Description = "A bootcamp for aspiring content creators.",
                CreatedBy = mockUsers[1],
                Attendees = new List<UserModel> { mockUsers[0], mockUsers[2] }
            },
            new EventModel
            {
                Id = 28,
                Name = "SEO and SEM Strategies",
                StartDate = new DateTime(2025, 02, 15, 9, 0, 0),
                EndDate = new DateTime(2025, 02, 15, 17, 0, 0),
                Location = "Berlin",
                Description = "A workshop on search engine optimization and marketing.",
                CreatedBy = mockUsers[2],
                Attendees = new List<UserModel> { mockUsers[3], mockUsers[4] }
            },
            new EventModel
            {
                Id = 29,
                Name = "Influencer Marketing Summit",
                StartDate = new DateTime(2025, 03, 20, 10, 0, 0),
                EndDate = new DateTime(2025, 03, 20, 17, 0, 0),
                Location = "Paris",
                Description = "A summit discussing the impact of influencer marketing.",
                CreatedBy = mockUsers[3],
                Attendees = new List<UserModel> { mockUsers[0], mockUsers[1] }
            },
            new EventModel
            {
                Id = 30,
                Name = "Email Marketing Mastery",
                StartDate = new DateTime(2025, 04, 25, 9, 0, 0),
                EndDate = new DateTime(2025, 04, 25, 17, 0, 0),
                Location = "London",
                Description = "A workshop on effective email marketing strategies.",
                CreatedBy = mockUsers[4],
                Attendees = new List<UserModel> { mockUsers[2], mockUsers[3] }
            },
            new EventModel
            {
                Id = 31,
                Name = "Data Analytics Workshop",
                StartDate = new DateTime(2025, 05, 30, 10, 0, 0),
                EndDate = new DateTime(2025, 05, 30, 16, 0, 0),
                Location = "Zurich",
                Description = "A workshop on data analytics and visualization.",
                CreatedBy = mockUsers[0],
                Attendees = new List<UserModel> { mockUsers[1], mockUsers[4] }
            },
            new EventModel
            {
                Id = 32,
                Name = "User Experience Design Conference",
                StartDate = new DateTime(2025, 06, 15, 9, 0, 0),
                EndDate = new DateTime(2025, 06, 15, 17, 0, 0),
                Location = "Amsterdam",
                Description = "A conference focusing on user experience design.",
                CreatedBy = mockUsers[1],
                Attendees = new List<UserModel> { mockUsers[0], mockUsers[3] }
            },
            new EventModel
            {
                Id = 33,
                Name = "Web Development Bootcamp",
                StartDate = new DateTime(2025, 07, 20, 10, 0, 0),
                EndDate = new DateTime(2025, 07, 20, 16, 0, 0),
                Location = "Lisbon",
                Description = "A bootcamp for aspiring web developers.",
                CreatedBy = mockUsers[2],
                Attendees = new List<UserModel> { mockUsers[3], mockUsers[4] }
            },
            new EventModel
            {
                Id = 34,
                Name = "Mobile App Development Workshop",
                StartDate = new DateTime(2025, 08, 25, 9, 0, 0),    
                EndDate = new DateTime(2025, 08, 25, 17, 0, 0),
                Location = "Madrid",
                Description = "A workshop on mobile app development.",
                CreatedBy = mockUsers[3],
                Attendees = new List<UserModel> { mockUsers[0], mockUsers[1] }
            },
            new EventModel
            {
                Id = 35,
                Name = "Cloud Computing Seminar",
                StartDate = new DateTime(2025, 09, 30, 10, 0, 0),
                EndDate = new DateTime(2025, 09, 30, 16, 0, 0),
                Location = "Berlin",
                Description = "A seminar on cloud computing technologies.",
                CreatedBy = mockUsers[4],
                Attendees = new List<UserModel> { mockUsers[2], mockUsers[3] }
            },
            new EventModel
            {
                Id = 36,
                Name = "Blockchain and Cryptocurrency Workshop",
                StartDate = new DateTime(2025, 10, 15, 9, 0, 0),
                EndDate = new DateTime(2025, 10, 15, 17, 0, 0),
                Location = "Tallinn",
                Description = "A workshop on blockchain technology and cryptocurrencies.",
                CreatedBy = mockUsers[0],
                Attendees = new List<UserModel> { mockUsers[1], mockUsers[4] }
            },
            new EventModel
            {
                Id = 37,
                Name = "Digital Transformation Conference",
                StartDate = new DateTime(2025, 11, 20, 10, 0, 0),
                EndDate = new DateTime(2025, 11, 20, 17, 0, 0),
                Location = "Helsinki",
                Description = "A conference discussing digital transformation strategies.",
                CreatedBy = mockUsers[1],
                Attendees = new List<UserModel> { mockUsers[0], mockUsers[3] }
            },
            new EventModel
            {
                Id = 38,
                Name = "Agile and Scrum Workshop",
                StartDate = new DateTime(2025, 12, 05, 9, 0, 0),
                EndDate = new DateTime(2025, 12, 05, 17, 0, 0),
                Location = "Copenhagen",
                Description = "A workshop on Agile methodologies and Scrum practices.",
                CreatedBy = mockUsers[2],
                Attendees = new List<UserModel> { mockUsers[3], mockUsers[4] }
            },
            new EventModel
            {
                Id = 39,
                Name = "Design Thinking Workshop",
                StartDate = new DateTime(2025, 01, 10, 10, 0, 0),
                EndDate = new DateTime(2025, 01, 10, 16, 0, 0),
                Location = "Amsterdam",
                Description = "A workshop on design thinking principles and practices.",
                CreatedBy = mockUsers[3],
                Attendees = new List<UserModel> { mockUsers[0], mockUsers[1] }
            },
            new EventModel
            {
                Id = 40,
                Name = "Product Management Seminar",
                StartDate = new DateTime(2025, 02, 15, 9, 0, 0),
                EndDate = new DateTime(2025, 02, 15, 17, 0, 0),
                Location = "Barcelona",
                Description = "A seminar on product management strategies.",
                CreatedBy = mockUsers[4],
                Attendees = new List<UserModel> { mockUsers[2], mockUsers[3] }
            }
        };
    }

    public void AddEvent(EventModel newEvent)
    {
        newEvent.Id = Events.Count > 0 ? Events.Max(e => e.Id) + 1 : 1; // Auto-generate ID
        Events.Add(newEvent);
    }
}