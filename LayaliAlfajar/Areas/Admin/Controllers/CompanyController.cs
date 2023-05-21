using Layali.DataAccess.Data;
using Layali.DataAccess.Repository.IRepository;
using Layali.Models;
using Layali.Models.ViewModels;
using Layali.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data;

namespace LayaliAlfajar.Areas.Admin.Controllers

//This is for Create
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class CompanyController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CompanyController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
       
        }

        public IActionResult Index()
        {
            List<Company> objCompanyList = _unitOfWork.Company.GetAll().ToList();
            return View(objCompanyList);
        }

        public IActionResult Upsert(int? id)
        {
           
            if (id==null || id == 0)
            {
                //create
                return View(new Company());
            }
            else
            {
                //update
                Company companyObj = _unitOfWork.Company.Get(u=>u.Id==id);
                return View(companyObj);
            }
            
        }
        [HttpPost]
        public IActionResult Upsert(Company CompanyObj)
        {

            if (ModelState.IsValid)
            {

                if (CompanyObj.Id == 0)
                {
                    _unitOfWork.Company.Add(CompanyObj);
                }
                else
                {
                    _unitOfWork.Company.Update(CompanyObj);
                }
                
                _unitOfWork.Save();
                TempData["Success"] = "Company created successfully";
                return RedirectToAction("Index");
            }
            else
            {
                return View(CompanyObj);
            }
                
            }
        //--------------------->>>instead we using Upsert to combine creat and update

        //THIS IS FOR EDIT 
        //public IActionResult Edit(int? id)
        //{
        //    if (id == null || id == 0)
        //    {
        //        return NotFound();
        //    }
        //    Company? companyFromDb = _unitOfWork.Company.Get(u => u.Id == id);
        //    if (companyFromDb == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(companyFromDb);
        //}
        //[HttpPost]
        //public IActionResult Edit(CompanyVM obj)
        //{

        //    if (ModelState.IsValid)
        //    {

        //        _unitOfWork.Company.Update(obj.Company);
        //        _unitOfWork.Save();
        //        TempData["Success"] = "Company updated successfully";
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}


        //THIS IS FOR DELETE

        //public IActionResult Delete(int? id)
        //{
        //    if (id == null || id == 0)
        //    {
        //        return NotFound();
        //    }
        //    Company? companyFromDb = _unitOfWork.Company.Get(u => u.Id == id);
        //    if (companyFromDb == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(companyFromDb);
        //}
        //[HttpPost, ActionName("Delete")]
        //public IActionResult DeletePost(int? id)
        //{
        //    Company? obj = _unitOfWork.Company.Get(u => u.Id == id);
        //    if (obj == null)
        //    {
        //        return NotFound();
        //    }
        //    _unitOfWork.Company.Remove(obj);
        //    _unitOfWork.Save();
        //    TempData["Success"] = "Company deleted successfully";
        //    return RedirectToAction("Index");



        //}

        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Company> objCompanyList = _unitOfWork.Company.GetAll().ToList();
            return Json(new {data=objCompanyList});
        }


        [HttpDelete]
        public IActionResult Delete(int? id)

        {
            var companyToBeDeleted = _unitOfWork.Company.Get(u=>u.Id == id);
            if (companyToBeDeleted == null)
            {
                   return Json(new {success = false, message = "Error while deleting" });

            }

            _unitOfWork.Company.Remove(companyToBeDeleted);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Delete Successful"});
        }

        #endregion
    }

}




