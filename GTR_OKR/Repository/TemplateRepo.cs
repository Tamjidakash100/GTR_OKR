﻿using AutoMapper;
using GTR_OKR.Context;
using GTR_OKR.DTO;
using GTR_OKR.Interfaces;
using GTR_OKR.Models;

namespace GTR_OKR.Repository
{
    public class TemplateRepo : ITemplate
    {
        private readonly OkrDbContext _context;
        private readonly IMapper _mapper;

        public TemplateRepo(OkrDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

       

        public string CreateTemp(TemplateDTO templateDTO)
        {
            //Template template = new Template
            //{
            //    Name = templateDTO.Name,
            //    OwnerId = templateDTO.OwnerId

            //};
            var template = _mapper.Map<Template>(templateDTO);

            _context.Templates.Add(template);
            var state = _context.SaveChanges();
            if (state > 0)
            {
                return "Successful";
            }
            return "Failed";
        }

       

        public string DeleteTemp(TemplateDTO templateDTO)
        {
            var template = _mapper.Map<Template>(templateDTO);
            _context.Templates.Remove(template);
            var state = (_context.SaveChanges());   
            if(state > 0) 
            {
                return "Delete Successful";
            }
            return "An Error Occurs..!!";
        }

        public string EditTemp(TemplateDTO templateDTO)
        {
            //Template template = new Template
            //{
            //    Name = templateDTO.Name,
            //    OwnerId = templateDTO.OwnerId

            //};
            var template = _mapper.Map<Template>(templateDTO);

            _context.Templates.Update(template);
            var state = (_context.SaveChanges());   
            if (state > 0) {
                return "Modify Successful..";
            }
            return "An Error Occur..!!";
        }
        public List<Template> GetTempOwner(int Id)
        {
            var data = _context.Templates.Where(x => x.OwnerId == Id).ToList();
            return data;

        }
        public string CreateTask(TasksDTO tasks)
        {
            var data = _mapper.Map<Tasks>(tasks);
            _context.Tasks.Add(data);
            var state = (_context.SaveChanges());
            if (state > 0)
            {
                return "Task Created...";
            }
            return "An Error Occur..!!";

        }
        public List<Tasks> GetTaskListByTemp(int tId)
        {
           return _context.Tasks.Where(x=> x.TempId==tId).ToList();
        }

       

        public string UpdateTask(TasksDTO task)
        {
            var tasks = _mapper.Map<Tasks>(task);
            _context.Tasks.Update(tasks);
           var state = (_context.SaveChanges());
            if (state > 0)
            {
                return "Updated..";
            }
           return "An Error Occured..!!";
        }

        public string DeleteTask(int id)
        {
          var task = _context.Tasks.Where(x => x.Id == id);
            if (task != null)
            {
                _context.Remove(task);
                _context.SaveChanges();
                return "Deleted Successful..";
            }
            return "An Error Occurred..!!";

        }

        public List<Tasks> GetTaskListByUser(int? userId)
        {
            if (UserExists(userId))
            {
                return _context.UserTaskAssigns.Where(c=>c.UserId==userId).Select(c=>c.Tasks).ToList();
            }
            return new List<Tasks>();
        }
        public List<Template> GetTempListByUser(int? userId)
        {
            if (UserExists(userId))
            {
                return _context.UserTempAssigns.Where(c => c.UserId == userId).Select(c => c.Template).ToList();
            }
            return new List<Template>();
        }

        public bool UserExists(int? userId)
        {
            return _context.Users.Any(c=>c.UserId == userId);
        }
        
    }
}
