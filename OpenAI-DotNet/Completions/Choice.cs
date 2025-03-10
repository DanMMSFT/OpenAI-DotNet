﻿using System.Text.Json.Serialization;

namespace OpenAI
{
    /// <summary>
    /// Represents a completion choice returned by the <see cref="CompletionEndpoint"/>.
    /// </summary>
    public sealed class Choice
    {
        /// <summary>
        /// The main text of the completion
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// If multiple completion choices we returned, this is the index withing the various choices
        /// </summary>
        [JsonPropertyName("index")]
        public int Index { get; set; }

        /// <summary>
        /// If the request specified <see cref="CompletionRequest.LogProbabilities"/>, this contains the list of the most likely tokens.
        /// </summary>
        [JsonPropertyName("logprobs")]
        public Logprobs Logprobs { get; set; }

        /// <summary>
        /// If this is the last segment of the completion result, this specifies why the completion has ended.
        /// </summary>
        [JsonPropertyName("finish_reason")]
        public string FinishReason { get; set; }

        /// <summary>
        /// Gets the main text of this completion
        /// </summary>
        public override string ToString() => $"{Index}|{FinishReason}|{Text}";

        public static implicit operator string(Choice choice) => choice.Text;
    }
}