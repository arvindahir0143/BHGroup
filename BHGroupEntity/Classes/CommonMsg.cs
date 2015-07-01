
using BHGroupEntity.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHGroup
{
    public static class CommonMsg
    {        
        public static string DependancyError()
        {
            return "The record can not be deleted. As it has related data.";
        }

        public static string DuplicateEntry(string entity)
        {
            return "Such " +entity+ " is already exist.";
        }

        public static string Error(string entity)
        {
            return "Some error occured while processing your request. Please try again.";
        }

        public static string Success(string entity, En_CRUD CRUDType)
        {
            if (CRUDType == En_CRUD.Insert)
                return Success_Insert(entity);
            else if (CRUDType == En_CRUD.Update)
                return Success_Update(entity);
            else if (CRUDType == En_CRUD.Delete)
                return Success_Delete(entity);
            else
                return "Your Request has been sucessfully processed.";
        } 

        public static string Success_Insert(string entity)
        {
            return entity + " has been inserted successfully.";
        }

        public static string Success_Update(string entity)
        {
            return entity + " has been updated successfully.";
        }

        public static string Success_Delete(string entity)
        {
            return entity + " has been deleted successfully.";
        }

        public static string Fail(string entity, En_CRUD CRUDType)
        {
            if (CRUDType == En_CRUD.Insert)
                return Fail_Insert(entity);
            else if (CRUDType == En_CRUD.Update)
                return Fail_Update(entity);
            else if (CRUDType == En_CRUD.Delete)
                return Fail_Delete(entity);
            else
                return "Your Request has been sucessfully processed.";
        } 

        public static string Fail_Insert(string entity)
        {
            return "Some error occured while inserting " + entity + ". Please try again.";
        }

        public static string Fail_Update(string entity)
        {
            return "Some error occured while updating " + entity + ". Please try again.";
        }

        public static string Fail_Delete(string entity)
        {
            return "Some error occured while deleting " + entity + ". Please try again.";
        }
    }
}
