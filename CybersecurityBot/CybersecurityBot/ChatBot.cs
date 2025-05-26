using System;
using CybersecurityBot.Bot;
using CybersecurityBot.Helpers;

public class ChatBot
{
    private readonly ResponseManager responseManager;
    private string currentTopic = null;
    private string lastQuestionAsked = null;
    private bool awaitingYesNo = false;
    private bool awaitingMoodResponse = false;

    public ChatBot()
    {
        responseManager = new ResponseManager();
    }

    public string GetResponse(string userInput)
    {
        string input = userInput.ToLower().Trim();

        // Small talk - "how are you"
        if (input.Contains("how are you"))
        {
            awaitingMoodResponse = true;
            return "I'm great, and you?";
        }

        if (awaitingMoodResponse)
        {
            if (input.Contains("good") || input.Contains("fine") || input.Contains("okay"))
            {
                awaitingMoodResponse = false;
                return "I'm glad to hear that!";
            }
            else if (input.Contains("bad") || input.Contains("not good") || input.Contains("sad"))
            {
                awaitingMoodResponse = false;
                return "Sorry to hear that. Want to talk about it?";
            }
        }

        // Check for yes/no while waiting
        if (awaitingYesNo)
        {
            if (input.Contains("yes"))
            {
                awaitingYesNo = false;
                return responseManager.GetFollowUp(currentTopic, true);
            }
            else if (input.Contains("no"))
            {
                awaitingYesNo = false;
                return responseManager.GetFollowUp(currentTopic, false);
            }
        }

        // Detect topic + emotion
        string topic = responseManager.DetectTopic(input);
        string emotion = responseManager.DetectEmotion(input);

        if (!string.IsNullOrEmpty(emotion))
        {
            return responseManager.GetEmotionResponse(emotion);
        }

        if (!string.IsNullOrEmpty(topic))
        {
            currentTopic = topic;
            var response = responseManager.GetTopicResponse(topic, input);
            if (responseManager.IsYesNoExpected(response))
            {
                awaitingYesNo = true;
                lastQuestionAsked = response;
            }
            return response;
        }

        // Fallback
        return responseManager.GetFallbackResponse();
    }

    public static void Start()
    {
        ChatBot bot = new ChatBot();
        while (true)
        {
            Console.Write("\nYou: ");
            string userInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userInput))
                continue;

            if (userInput.Trim().ToLower() == "bye" || userInput.Trim().ToLower() == "exit")
                break;

            string response = bot.GetResponse(userInput);
            TextEffects.TypeLine($"\nBot: {response}", 25, ConsoleColor.Yellow);
        }
    }
}
