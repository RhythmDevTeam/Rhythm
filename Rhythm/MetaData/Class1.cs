using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaData
{
    public class Subject : ISubject
    {
        public Subject GetSubject(int subjectId)
        {
            return null;
        }
    }
    public class Chapter : IChapter
    {
        public Chapter[] GetChapters(int subjectId)
        {
            return null;
        }

    }
    public class Topic : ITopic
    {
        public Topic[] GetTopics(int chapterId)
        {
            return null;
        }

    }
    public class Subtopic : ISubtopic
    {
        public Subtopic[] GetSubTopics(int subtopicId)
        {
            return null;
        }
    }
    public class SubtopicDescription : ISubtopicDescription
    {
        public SubtopicDescription[] GetSubDescription(int subtopicId)
        {
            return null;
        }
    }
    public class TopicDesrciption : ITopic
    {
    }
    public class Script : IScript
    {
    }


    public interface ISubject
    {
        Subject GetSubject(int subjectId);
    }
    public interface IChapter
    {
    }
    public interface ITopic
    {
    }
    public interface ISubtopic
    {
    }
    public interface ISubtopicDescription
    {
    }
    public interface ITopicDesrciption
    {
    }
    public interface IScript
    {
    }

}
