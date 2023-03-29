Consider creating a C# class to represent the xml schema that you put in your post. Using your snippet (and closing a few tags to make its syntax valid) it's possible to use an online generator (for example https://json2csharp.com/code-converters/xml-to-csharp) to create a functioning C# class without having to code things manually.
 
Then you can access the list of `DayOfWeek` elements and "**put all the value [...] in 3 textboxs**" using conventional C# syntax.

[![after-click-test][1]][1]

    private void onClickTest(object sender, EventArgs e)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Root));
        using (StringReader reader = new StringReader(mockSource))
        {
            Root root = (Root)serializer.Deserialize(reader);

            var listDayOfWeek = root
                .GetFixtureByRaceResponse
                .RacingEvent
                .Meeting
                .MeetingInfo
                .DayOfWeek;

            foreach (var dayOfWeekElement in listDayOfWeek)
            {
                try
                {
                    switch (dayOfWeekElement.Lang)
                    {
                        case "en-us":
                            textBox1.Text = dayOfWeekElement.Text;
                            break;
                        case "zh-cn":
                            textBox2.Text = dayOfWeekElement.Text;
                            break;
                        case "zh-hk":
                            textBox3.Text = dayOfWeekElement.Text;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Debug.Assert(false, ex.Message);
                }
            }
        }
    }

***
**Generated**

    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Xml.Serialization;


    // G E N E R A T E D
    // https://json2csharp.com/code-converters/xml-to-csharp

    namespace find_element_by_tag
    {
        [XmlRoot(ElementName = "Root", Namespace = "")]
        public class Root
        {

            [XmlElement(ElementName = "GetFixtureByRaceResponse", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public GetFixtureByRaceResponse GetFixtureByRaceResponse { get; set; }
        }

        [XmlRoot(ElementName = "Return", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
        public class Return
        {

            [XmlElement(ElementName = "Code", Namespace = "http://www.hkjc.org.hk/Schema/CAP/Common_v2")]
            public int Code { get; set; }

            [XmlElement(ElementName = "EndOf_v2_0Elm", Namespace = "http://www.hkjc.org.hk/Schema/CAP/Common_v2")]
            public object EndOfV20Elm { get; set; }
        }

        [XmlRoot(ElementName = "DayOfWeek", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
        public class DayOfWeek
        {

            [XmlAttribute(AttributeName = "lang", Namespace = "")]
            public string Lang { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "MeetingInfo", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
        public class MeetingInfo
        {

            [XmlElement(ElementName = "DayOfWeek", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public List<DayOfWeek> DayOfWeek { get; set; }

            [XmlElement(ElementName = "Status", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public string Status { get; set; }

            [XmlElement(ElementName = "RaceSeason", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public string RaceSeason { get; set; }

            [XmlElement(ElementName = "NumOfRace", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public int NumOfRace { get; set; }

            [XmlElement(ElementName = "MeetingNo", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public int MeetingNo { get; set; }

            [XmlElement(ElementName = "TrackCode", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public string TrackCode { get; set; }

            [XmlElement(ElementName = "MeetingType", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public string MeetingType { get; set; }

            [XmlElement(ElementName = "ScheduledNumOfRace", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public int ScheduledNumOfRace { get; set; }

            [XmlElement(ElementName = "ActualNumOfRace", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public int ActualNumOfRace { get; set; }

            [XmlElement(ElementName = "EndOf_v2_0Elm", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public object EndOfV20Elm { get; set; }
        }

        [XmlRoot(ElementName = "Meeting", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
        public class Meeting
        {

            [XmlElement(ElementName = "MeetingInfo", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public MeetingInfo MeetingInfo { get; set; }

            [XmlElement(ElementName = "EndOf_v2_0Elm", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public object EndOfV20Elm { get; set; }

            [XmlAttribute(AttributeName = "meetingDate", Namespace = "")]
            public string MeetingDate { get; set; }

            [XmlAttribute(AttributeName = "meetingID", Namespace = "")]
            public string MeetingID { get; set; }

            [XmlAttribute(AttributeName = "statusLastUpdated", Namespace = "")]
            public DateTime StatusLastUpdated { get; set; }

            [XmlAttribute(AttributeName = "venueCode", Namespace = "")]
            public string VenueCode { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "RaceName", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
        public class RaceName
        {

            [XmlAttribute(AttributeName = "lang", Namespace = "")]
            public string Lang { get; set; }

            [XmlAttribute(AttributeName = "seqNo", Namespace = "")]
            public string SeqNo { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "PrizeMoney", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
        public class PrizeMoney
        {

            [XmlAttribute(AttributeName = "prizeLevel", Namespace = "")]
            public string PrizeLevel { get; set; }

            [XmlText]
            public double Text { get; set; }
        }

        [XmlRoot(ElementName = "RaceRemarks", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
        public class RaceRemarks
        {

            [XmlAttribute(AttributeName = "lang", Namespace = "")]
            public string Lang { get; set; }

            [XmlAttribute(AttributeName = "seqNo", Namespace = "")]
            public string SeqNo { get; set; }
        }

        [XmlRoot(ElementName = "Footnotes", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
        public class Footnotes
        {

            [XmlAttribute(AttributeName = "lang", Namespace = "")]
            public string Lang { get; set; }

            [XmlAttribute(AttributeName = "seqNo", Namespace = "")]
            public string SeqNo { get; set; }
        }

        [XmlRoot(ElementName = "StarterRemarks", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
        public class StarterRemarks
        {

            [XmlAttribute(AttributeName = "lang", Namespace = "")]
            public string Lang { get; set; }

            [XmlAttribute(AttributeName = "seqNo", Namespace = "")]
            public string SeqNo { get; set; }
        }

        [XmlRoot(ElementName = "Local", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
        public class Local
        {

            [XmlElement(ElementName = "RaceIndex", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public int RaceIndex { get; set; }

            [XmlElement(ElementName = "ClassCode", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public int ClassCode { get; set; }

            [XmlElement(ElementName = "TrackCode", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public string TrackCode { get; set; }

            [XmlElement(ElementName = "CourseCode", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public string CourseCode { get; set; }

            [XmlElement(ElementName = "RatingRange", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public string RatingRange { get; set; }

            [XmlElement(ElementName = "RatingType", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public string RatingType { get; set; }

            [XmlElement(ElementName = "RaceType", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public string RaceType { get; set; }

            [XmlElement(ElementName = "FieldSize", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public int FieldSize { get; set; }

            [XmlElement(ElementName = "CupIndex", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public object CupIndex { get; set; }

            [XmlElement(ElementName = "Footnotes", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public List<Footnotes> Footnotes { get; set; }

            [XmlElement(ElementName = "InternationalRaceIndicator", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public int InternationalRaceIndicator { get; set; }

            [XmlElement(ElementName = "SectionNo", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public int SectionNo { get; set; }

            [XmlElement(ElementName = "Going", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public object Going { get; set; }

            [XmlElement(ElementName = "SpecialRaceIndicator", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public object SpecialRaceIndicator { get; set; }

            [XmlElement(ElementName = "SecDivDisplayIndicator", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public string SecDivDisplayIndicator { get; set; }

            [XmlElement(ElementName = "StarterRemarks", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public List<StarterRemarks> StarterRemarks { get; set; }

            [XmlElement(ElementName = "EndOf_v2_0Elm", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public object EndOfV20Elm { get; set; }
        }

        [XmlRoot(ElementName = "RaceInfo", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
        public class RaceInfo
        {

            [XmlElement(ElementName = "Status", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public string Status { get; set; }

            [XmlElement(ElementName = "PostTime", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public DateTime PostTime { get; set; }

            [XmlElement(ElementName = "RaceName", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public List<RaceName> RaceName { get; set; }

            [XmlElement(ElementName = "Distance", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public int Distance { get; set; }

            [XmlElement(ElementName = "NoOfDeclaredStarters", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public int NoOfDeclaredStarters { get; set; }

            [XmlElement(ElementName = "PrizeMoney", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public List<PrizeMoney> PrizeMoney { get; set; }

            [XmlElement(ElementName = "StakePrize", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public double StakePrize { get; set; }

            [XmlElement(ElementName = "RaceRemarks", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public List<RaceRemarks> RaceRemarks { get; set; }

            [XmlElement(ElementName = "Local", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public Local Local { get; set; }

            [XmlElement(ElementName = "WageringFieldSize", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public int WageringFieldSize { get; set; }

            [XmlElement(ElementName = "EndOf_v2_0Elm", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public object EndOfV20Elm { get; set; }
        }

        [XmlRoot(ElementName = "Race", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
        public class Race
        {

            [XmlElement(ElementName = "RaceInfo", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public RaceInfo RaceInfo { get; set; }

            [XmlElement(ElementName = "EndOf_v2_0Elm", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public object EndOfV20Elm { get; set; }

            [XmlAttribute(AttributeName = "meetingID", Namespace = "")]
            public string MeetingID { get; set; }

            [XmlAttribute(AttributeName = "raceID", Namespace = "")]
            public string RaceID { get; set; }

            [XmlAttribute(AttributeName = "raceNo", Namespace = "")]
            public string RaceNo { get; set; }

            [XmlAttribute(AttributeName = "statusLastUpdated", Namespace = "")]
            public DateTime StatusLastUpdated { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "RacingEvent", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
        public class RacingEvent
        {

            [XmlElement(ElementName = "Meeting", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public Meeting Meeting { get; set; }

            [XmlElement(ElementName = "Race", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public Race Race { get; set; }
        }

        [XmlRoot(ElementName = "GetFixtureByRaceResponse", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
        public class GetFixtureByRaceResponse
        {

            [XmlElement(ElementName = "Return", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public Return Return { get; set; }

            [XmlElement(ElementName = "RacingEvent", Namespace = "http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2")]
            public RacingEvent RacingEvent { get; set; }

            [XmlAttribute(AttributeName = "ns2", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Ns2 { get; set; }

            [XmlAttribute(AttributeName = "xmlns", Namespace = "")]
            public string Xmlns { get; set; }

            [XmlText]
            public string Text { get; set; }
        }
    }

***
Where:

    const string mockSource = @"
    <Root>
       <ns2:GetFixtureByRaceResponse xmlns:ns2=""http://www.hkjc.org.hk/Schema/CAP/IDASUBRS/FixtureLocal_v2"" xmlns=""http://www.hkjc.org.hk/Schema/CAP/Common_v2"">
          <ns2:Return>
             <Code>0</Code>
             <EndOf_v2_0Elm />
          </ns2:Return>
          <ns2:RacingEvent>
             <ns2:Meeting meetingDate=""2022-09-11+08:00"" meetingID=""MTG_20220911_0001"" statusLastUpdated=""2022-09-07T14:22:17.000+08:00"" venueCode=""ST"">
                <ns2:MeetingInfo>
                   <ns2:DayOfWeek lang=""en-us"">SUN</ns2:DayOfWeek>
                   <ns2:DayOfWeek lang=""zh-cn"">星期日</ns2:DayOfWeek>
                   <ns2:DayOfWeek lang=""zh-hk"">星期日</ns2:DayOfWeek>
                   <ns2:Status>Defined</ns2:Status>
                   <ns2:RaceSeason>22/23</ns2:RaceSeason>
                   <ns2:NumOfRace>10</ns2:NumOfRace>
                   <ns2:MeetingNo>01</ns2:MeetingNo>
                   <ns2:TrackCode>TURF</ns2:TrackCode>
                   <ns2:MeetingType>D</ns2:MeetingType>
                   <ns2:ScheduledNumOfRace>10</ns2:ScheduledNumOfRace>
                   <ns2:ActualNumOfRace>0</ns2:ActualNumOfRace>
                   <ns2:EndOf_v2_0Elm />
                </ns2:MeetingInfo>
                <ns2:EndOf_v2_0Elm />
             </ns2:Meeting>
             <ns2:Race meetingID=""MTG_20220911_0001"" raceID=""RACE_20220911_0010"" raceNo=""1"" statusLastUpdated=""2022-09-07T09:06:53.522+08:00"">
                <ns2:RaceInfo>
                    <ns2:Status>Declared</ns2:Status>
                    <ns2:PostTime>2022-09-11T13:00:00.000+08:00</ns2:PostTime>
                    <ns2:RaceName lang=""en-us"" seqNo=""1"">MOUNT PARKER HANDICAP</ns2:RaceName>
                    <ns2:RaceName lang=""zh-cn"" seqNo=""1"">柏架山让赛</ns2:RaceName>
                    <ns2:RaceName lang=""zh-hk"" seqNo=""1"">柏架山讓賽</ns2:RaceName>
                    <ns2:Distance>1600</ns2:Distance>
                    <ns2:NoOfDeclaredStarters>14</ns2:NoOfDeclaredStarters>
                    <ns2:PrizeMoney prizeLevel=""1"">461700.00</ns2:PrizeMoney>
                    <ns2:PrizeMoney prizeLevel=""2"">178200.00</ns2:PrizeMoney>
                    <ns2:PrizeMoney prizeLevel=""3"">93150.00</ns2:PrizeMoney>
                    <ns2:PrizeMoney prizeLevel=""4"">48600.00</ns2:PrizeMoney>
                    <ns2:PrizeMoney prizeLevel=""5"">28350.00</ns2:PrizeMoney>
                    <ns2:PrizeMoney prizeLevel=""6"">0.00</ns2:PrizeMoney>
                    <ns2:PrizeMoney prizeLevel=""7"">0.00</ns2:PrizeMoney>
                    <ns2:PrizeMoney prizeLevel=""8"">0.00</ns2:PrizeMoney>
                    <ns2:PrizeMoney prizeLevel=""9"">0.00</ns2:PrizeMoney>
                    <ns2:StakePrize>810000.00000</ns2:StakePrize>
                    <ns2:RaceRemarks lang=""en-us"" seqNo=""1"" />
                    <ns2:RaceRemarks lang=""en-us"" seqNo=""2"" />
                    <ns2:RaceRemarks lang=""en-us"" seqNo=""3"" />
                    <ns2:RaceRemarks lang=""en-us"" seqNo=""4"" />
                    <ns2:RaceRemarks lang=""en-us"" seqNo=""5"" />
                    <ns2:RaceRemarks lang=""en-us"" seqNo=""6"" />
                    <ns2:RaceRemarks lang=""en-us"" seqNo=""7"" />
                    <ns2:RaceRemarks lang=""en-us"" seqNo=""8"" />
                    <ns2:RaceRemarks lang=""zh-cn"" seqNo=""1"" />
                    <ns2:RaceRemarks lang=""zh-cn"" seqNo=""2"" />
                    <ns2:RaceRemarks lang=""zh-cn"" seqNo=""3"" />
                    <ns2:RaceRemarks lang=""zh-cn"" seqNo=""4"" />
                    <ns2:RaceRemarks lang=""zh-cn"" seqNo=""5"" />
                    <ns2:RaceRemarks lang=""zh-cn"" seqNo=""6"" />
                    <ns2:RaceRemarks lang=""zh-cn"" seqNo=""7"" />
                    <ns2:RaceRemarks lang=""zh-cn"" seqNo=""8"" />
                    <ns2:RaceRemarks lang=""zh-hk"" seqNo=""1"" />
                    <ns2:RaceRemarks lang=""zh-hk"" seqNo=""2"" />
                    <ns2:RaceRemarks lang=""zh-hk"" seqNo=""3"" />
                    <ns2:RaceRemarks lang=""zh-hk"" seqNo=""4"" />
                    <ns2:RaceRemarks lang=""zh-hk"" seqNo=""5"" />
                    <ns2:RaceRemarks lang=""zh-hk"" seqNo=""6"" />
                    <ns2:RaceRemarks lang=""zh-hk"" seqNo=""7"" />
                    <ns2:RaceRemarks lang=""zh-hk"" seqNo=""8"" />
                    <ns2:Local>
                        <ns2:RaceIndex>1</ns2:RaceIndex>
                        <ns2:ClassCode>5</ns2:ClassCode>
                        <ns2:TrackCode>TURF</ns2:TrackCode>
                        <ns2:CourseCode>A</ns2:CourseCode>
                        <ns2:RatingRange>040-000</ns2:RatingRange>
                        <ns2:RatingType>H</ns2:RatingType>
                        <ns2:RaceType>H</ns2:RaceType>
                        <ns2:FieldSize>14</ns2:FieldSize>
                        <ns2:CupIndex />
                        <ns2:Footnotes lang=""en-us"" seqNo=""1"" />
                        <ns2:Footnotes lang=""en-us"" seqNo=""2"" />
                        <ns2:Footnotes lang=""en-us"" seqNo=""3"" />
                        <ns2:Footnotes lang=""en-us"" seqNo=""4"" />
                        <ns2:Footnotes lang=""zh-hk"" seqNo=""1"" />
                        <ns2:Footnotes lang=""zh-hk"" seqNo=""2"" />
                        <ns2:Footnotes lang=""zh-hk"" seqNo=""3"" />
                        <ns2:Footnotes lang=""zh-hk"" seqNo=""4"" />
                        <ns2:InternationalRaceIndicator>0</ns2:InternationalRaceIndicator>
                        <ns2:SectionNo>1</ns2:SectionNo>
                        <ns2:Going />
                        <ns2:SpecialRaceIndicator />
                        <ns2:SecDivDisplayIndicator>S</ns2:SecDivDisplayIndicator>
                        <ns2:StarterRemarks lang=""en-us"" seqNo=""1"" />
                        <ns2:StarterRemarks lang=""en-us"" seqNo=""2"" />
                        <ns2:StarterRemarks lang=""en-us"" seqNo=""3"" />
                        <ns2:StarterRemarks lang=""en-us"" seqNo=""4"" />
                        <ns2:StarterRemarks lang=""en-us"" seqNo=""5"" />
                        <ns2:StarterRemarks lang=""en-us"" seqNo=""6"" />
                        <ns2:StarterRemarks lang=""en-us"" seqNo=""7"" />
                        <ns2:StarterRemarks lang=""en-us"" seqNo=""8"" />
                        <ns2:StarterRemarks lang=""zh-cn"" seqNo=""1"" />
                        <ns2:StarterRemarks lang=""zh-cn"" seqNo=""2"" />
                        <ns2:StarterRemarks lang=""zh-cn"" seqNo=""3"" />
                        <ns2:StarterRemarks lang=""zh-cn"" seqNo=""4"" />
                        <ns2:StarterRemarks lang=""zh-cn"" seqNo=""5"" />
                        <ns2:StarterRemarks lang=""zh-cn"" seqNo=""6"" />
                        <ns2:StarterRemarks lang=""zh-cn"" seqNo=""7"" />
                        <ns2:StarterRemarks lang=""zh-cn"" seqNo=""8"" />
                        <ns2:StarterRemarks lang=""zh-hk"" seqNo=""1"" />
                        <ns2:StarterRemarks lang=""zh-hk"" seqNo=""2"" />
                        <ns2:StarterRemarks lang=""zh-hk"" seqNo=""3"" />
                        <ns2:StarterRemarks lang=""zh-hk"" seqNo=""4"" />
                        <ns2:StarterRemarks lang=""zh-hk"" seqNo=""5"" />
                        <ns2:StarterRemarks lang=""zh-hk"" seqNo=""6"" />
                        <ns2:StarterRemarks lang=""zh-hk"" seqNo=""7"" />
                        <ns2:StarterRemarks lang=""zh-hk"" seqNo=""8"" />
                        <ns2:EndOf_v2_0Elm />
                    </ns2:Local>
                    <ns2:WageringFieldSize>14</ns2:WageringFieldSize>
                    <ns2:EndOf_v2_0Elm />
                    </ns2:RaceInfo>
                <ns2:EndOf_v2_0Elm />
             </ns2:Race>
		    </ns2:RacingEvent>
        </ns2:GetFixtureByRaceResponse>
    </Root>
    ";



  [1]: https://i.stack.imgur.com/HRxE6.png