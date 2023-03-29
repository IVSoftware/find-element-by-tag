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
