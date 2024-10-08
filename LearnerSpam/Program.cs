using System.Net.Mime;
using System.Text;
using System.Text.Json;
using LearnerSpam.Enums.ScenarioTraining;
using LearnerSpam.ScenarioTraining;

namespace LearnerSpam
{
    internal class Program
    {

        private static Random random = new Random();

        private static string authToken = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6IlJFUTBNVVE1TjBOQ1JUSkVNemszTTBVMVJrTkRRMFUwUTBNMVJFRkJSamhETWpkRU5VRkJRZyJ9.eyJpc3MiOiJodHRwczovL2ZpZG0uZ2lneWEuY29tL2p3dC80X0R4UU9JLUdGZEltWGo1S0lzRjRPLWcvIiwiYXBpS2V5IjoiNF9EeFFPSS1HRmRJbVhqNUtJc0Y0Ty1nIiwiaWF0IjoxNzI3MjQ0MjIzLCJleHAiOjE3MjcyODc0MjMsInN1YiI6IjkwOTk4YjgxYTA2ZjQzMTA4NjBhNjUyN2M0Y2I0MGQ3IiwiZmlyc3ROYW1lIjoiS3Jpc3RpYW4iLCJsYXN0TmFtZSI6IkpvaGFuc2VuIiwiZW1haWwiOiJrcmlzdGlhbi5qb2hhbnNlbkBsYWVyZGFsLmNvbSJ9.GVOyDjS1pI-uE72lb6Sqvm4BW23G5AFx_bCJ6yqCIO2T-UnSnf2WUZez_Yak1DKjPB2vzqghHjAyTdLAyyEwK6jWXFFpOLPrpvd2uqW2BzRJslFg9crKWe1uLJ3eF-lkmG96HUfQc-VFLi83sDofFyuhQxkYND3H1S50RA64-yBqd_Sh7mgrwE7MnGdUvGW2dv4-Bf4bx9hhWsB8bFbZvl81VnlcK_R-CPGpdZrU48LhjI10sae8Nuaxq-n0_ht2HHCLsF89aJJAyBXNTuEtEKQylpWwhKjs2-FcuOavdXOLjjcy8Jdc7FMzrHmxD8IjzPlvFZQjLEK-v1t24r2dTA";
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        static async Task Main(string[] args)
        {
            using HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7188");
            var count = 0;
            while (true)
            {
                Console.WriteLine($"Creating session {count}");
                var session = CreateRandoSession();
                var message = new HttpRequestMessage(HttpMethod.Post, "/api/scenariotraining/ScenarioTrainingSession")
                {
                    Content = new StringContent(JsonSerializer.Serialize(session), Encoding.UTF8, MediaTypeNames.Application.Json)
                };
                message.Headers.Add("Authorization", "Bearer " + authToken);

                _ = client.SendAsync(message, CancellationToken.None)
                    .ContinueWith(async (a, c) =>
                    {
                        var t = await a;
                        Console.WriteLine($"completed session {c}: HTTP {t.StatusCode}");
                    }, count);
                await Task.Delay(300);
                count++;
            }


        }

        private static ScenarioTrainingSessionAppDto CreateRandoSession()
        {
            return new ScenarioTrainingSessionAppDto()
            {
                Created = DateTimeOffset.Now,
                Id = Guid.NewGuid(),
                FeatureType = FeatureType.Default,
                ScenarioId = Guid.Parse("EC0BB311-9A6B-485A-BB7B-615509FDD74C"),
                ScenarioTitle = "Retained Placenta",
                Updated = DateTimeOffset.Now,
                Facilitators = new List<ScenarioTrainingLearnerAppDto>()
                    {
                        new ScenarioTrainingLearnerAppDto()
                        {
                            Id = Guid.NewGuid(),
                            Created = DateTimeOffset.Now,
                            LearnerId = Guid.NewGuid(),
                            Name = RandomString(random.Next(5, 15)),
                        },
                        new ScenarioTrainingLearnerAppDto()
                        {
                            Id = Guid.NewGuid(),
                            Created = DateTimeOffset.Now,
                            LearnerId = Guid.NewGuid(),
                            Name = RandomString(random.Next(5, 15)),
                        }
                    },
                Learners = new List<ScenarioTrainingLearnerAppDto>()
                    {
                        new ScenarioTrainingLearnerAppDto()
                        {
                            Id = Guid.NewGuid(),
                            Created = DateTimeOffset.Now,
                            LearnerId = Guid.NewGuid(),
                            Name = RandomString(random.Next(5, 15)),
                        },
                        new ScenarioTrainingLearnerAppDto()
                        {
                            Id = Guid.NewGuid(),
                            Created = DateTimeOffset.Now,
                            LearnerId = Guid.NewGuid(),
                            Name = RandomString(random.Next(5, 15)),
                        },
                        new ScenarioTrainingLearnerAppDto()
                        {
                            Id = Guid.NewGuid(),
                            Created = DateTimeOffset.Now,
                            LearnerId = Guid.NewGuid(),
                            Name = RandomString(random.Next(5, 15)),
                        },
                        new ScenarioTrainingLearnerAppDto()
                        {
                            Id = Guid.NewGuid(),
                            Created = DateTimeOffset.Now,
                            LearnerId = Guid.NewGuid(),
                            Name = RandomString(random.Next(5, 15)),
                        },
                        new ScenarioTrainingLearnerAppDto()
                        {
                            Id = Guid.NewGuid(),
                            Created = DateTimeOffset.Now,
                            LearnerId = Guid.NewGuid(),
                            Name = RandomString(random.Next(5, 15)),
                        },
                        new ScenarioTrainingLearnerAppDto()
                        {
                            Id = Guid.NewGuid(),
                            Created = DateTimeOffset.Now,
                            LearnerId = Guid.NewGuid(),
                            Name = RandomString(random.Next(5, 15)),
                        },
                        new ScenarioTrainingLearnerAppDto()
                        {
                            Id = Guid.NewGuid(),
                            Created = DateTimeOffset.Now,
                            LearnerId = Guid.NewGuid(),
                            Name = RandomString(random.Next(5, 15)),
                        },
                        new ScenarioTrainingLearnerAppDto()
                        {
                            Id = Guid.NewGuid(),
                            Created = DateTimeOffset.Now,
                            LearnerId = Guid.NewGuid(),
                            Name = RandomString(random.Next(5, 15)),
                        }
                    },
                LearningObjectives = new List<ScenarioTrainingSessionLearningObjectiveAppDto>()
                    {
                        new ScenarioTrainingSessionLearningObjectiveAppDto()
                        {
                            Id = Guid.NewGuid(),
                            Created = DateTimeOffset.Now,
                            Order = 1,
                            Title = RandomString(random.Next(20, 30)),
                        },
                        new ScenarioTrainingSessionLearningObjectiveAppDto()
                        {
                            Id = Guid.NewGuid(),
                            Created = DateTimeOffset.Now,
                            Order = 2,
                            Title = RandomString(random.Next(20, 30)),
                        },
                        new ScenarioTrainingSessionLearningObjectiveAppDto()
                        {
                            Id = Guid.NewGuid(),
                            Created = DateTimeOffset.Now,
                            Order = 3,
                            Title = RandomString(random.Next(20, 30)),
                        }
                    },
                Inputs = new List<ScenarioTrainingInputAppDto>()
                    {
                        new ScenarioTrainingInputAppDto()
                        {
                            Id = Guid.NewGuid(),
                            Created = DateTimeOffset.Now,
                            Order = 1,
                            InputType = ScenarioTrainingSessionInputType.SuccessesObserved,
                            Text = RandomString(random.Next(20, 30)),
                        },
                        new ScenarioTrainingInputAppDto()
                        {
                            Id = Guid.NewGuid(),
                            Created = DateTimeOffset.Now,
                            Order = 2,
                            InputType = ScenarioTrainingSessionInputType.SuccessesObserved,
                            Text = RandomString(random.Next(20, 30)),
                        },
                        new ScenarioTrainingInputAppDto()
                        {
                            Id = Guid.NewGuid(),
                            Created = DateTimeOffset.Now,
                            Order = 1,
                            InputType = ScenarioTrainingSessionInputType.ChallengesObserved,
                            Text = RandomString(random.Next(20, 30)),
                        },
                        new ScenarioTrainingInputAppDto()
                        {
                            Id = Guid.NewGuid(),
                            Created = DateTimeOffset.Now,
                            Order = 2,
                            InputType = ScenarioTrainingSessionInputType.ChallengesObserved,
                            Text = RandomString(random.Next(20, 30)),
                        },
                        new ScenarioTrainingInputAppDto()
                        {
                            Id = Guid.NewGuid(),
                            Created = DateTimeOffset.Now,
                            Order = 1,
                            InputType = ScenarioTrainingSessionInputType.KeyLearnings,
                            Text = RandomString(random.Next(20, 30)),
                        },
                        new ScenarioTrainingInputAppDto()
                        {
                            Id = Guid.NewGuid(),
                            Created = DateTimeOffset.Now,
                            Order = 2,
                            InputType = ScenarioTrainingSessionInputType.KeyLearnings,
                            Text = RandomString(random.Next(20, 30)),
                        },
                    },
            };
        }
    }
}
