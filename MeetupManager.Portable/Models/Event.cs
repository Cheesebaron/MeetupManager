/*
 * MeetupManager:
 * Copyright (C) 2013 Refractored LLC: 
 * http://github.com/JamesMontemagno
 * http://twitter.com/JamesMontemagno
 * http://refractored.com
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;
using Newtonsoft.Json;

namespace MeetupManager.Portable.Models
{
	public class Event
	{
		public Event ()
		{
		}

		[JsonProperty("status")]
		public string Status { get; set; }

		[JsonProperty("visibility")]
		public string Visibility { get; set; }

		[JsonProperty("maybe_rsvp_count")]
		public int MaybeRSVPCount { get; set; }

		[JsonProperty("venue")]
		public Venue Venue { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("utc_offset")]
		public int UTCOffset { get; set; }

		[JsonProperty("duration")]
		public int Duration { get; set; }

		[JsonProperty("time")]
		public long Time { get; set; }

		[JsonIgnore]
		public string Month 
		{
			get 
			{ 
				return FromUnixTime(Time).ToString("MM"); 
			} 
		}

		public DateTime FromUnixTime(long unixTime)
		{
			var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
			return epoch.AddMilliseconds(unixTime);
		}

		[JsonIgnore]
		public string Year 
		{
			get 
			{
				return FromUnixTime(Time).ToString("yyyy"); 
			} 
		}

		[JsonIgnore]
		public string Day { get { return FromUnixTime(Time).ToString("dd"); } }

		[JsonIgnore]
		public string MonthDay { get { return FromUnixTime(Time).ToString("MM/dd");  } }

		[JsonProperty("waitlist_count")]
		public int WaitlistCount { get; set; }

		[JsonProperty("announced")]
		public bool Announced { get; set; }

		[JsonProperty("updated")]
		public long Updated { get; set; }

		[JsonProperty("yes_rsvp_count")]
		public int YesRSVPCount { get; set; }

		[JsonProperty("created")]
		public long Created { get; set; }

		[JsonProperty("event_url")]
		public string EventUrl { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("how_to_find_us")]
		public string HowToFindUs { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("headcount")]
		public int HeadCount { get; set; }

		[JsonProperty("group")]
		public Group Group { get; set; }
	}
}

