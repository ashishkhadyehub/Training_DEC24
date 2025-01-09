using EMS.Models;
using EMS.Repositories.Interfaces;
using EMS.UI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EMS.UI.Controllers
{
    public class AdminController : Controller
    {

        private readonly IGenericRepo<Branch> _branchRepo;
        private readonly IGenericRepo<Department> _departmentRepo;

        public AdminController(IGenericRepo<Branch> branchRepo, IGenericRepo<Department> departmentRepo)
        {
            _branchRepo = branchRepo;
            _departmentRepo = departmentRepo;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(AdminViewModel vm)
        {
            if (vm.UserName == "admin" && vm.Password == "admin")
            {
                
                HttpContext.Session.SetString("Admin", "True");
                return RedirectToAction("BranchList");
            }
            else
            {
                ViewData["Message"] = "Invalid Login";
                return View();
            }

        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }


        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> BranchList()
        {
            //Branch
            var branchList = await _branchRepo.GetAll();
            List<BranchViewModel> vm = new List<BranchViewModel>();
            foreach (var branch in branchList)
            {
                vm.Add(new BranchViewModel
                {
                    Id = branch.Id,
                    BranchName = branch.BranchName,
                    BranchHead = branch.BranchHead,
                    Address = branch.Address
                });
            }
            return View(vm);
        }

        [HttpGet]
        public async Task<IActionResult> CreateBranch()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBranch(BranchViewModel vm)
        {
            var branch = new Branch
            {
                BranchName = vm.BranchName,
                BranchHead = vm.BranchHead,
                Address = vm.Address


            };
            await _branchRepo.Save(branch);
            TempData["Message"] = "True";
            return RedirectToAction("BranchList");
        }

        [HttpGet]
        public async Task<IActionResult> EditBranch(int id)
        {
            var branch = await _branchRepo.GetById(id);
            var vm = new BranchViewModel { Id = branch.Id, BranchName = branch.BranchName, BranchHead = branch.BranchHead, Address = branch.Address };
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> EditBranch(BranchViewModel vm)
        {
            var branch = new Branch
            {
                Id = vm.Id,
                BranchName = vm.BranchName,
                BranchHead = vm.BranchHead,
                Address = vm.Address,
            };

            await _branchRepo.Edit(branch);
            return RedirectToAction("BranchList");


        }

        public async Task<IActionResult> DeleteBranch(BranchViewModel vm)
        {
            var branch = new Branch
            {
                Id = vm.Id,
                BranchName = vm.BranchName,
                BranchHead = vm.BranchHead,
                Address = vm.Address,
            };
            await _branchRepo.RemoveData(branch);
            return RedirectToAction("BranchList");
        }

        public async Task<IActionResult> DeptList()
        {
            var departments = await _departmentRepo.GetAll();
            var vm = new List<DeptViewModel>();
            foreach (var department in departments)
            {
                vm.Add(new DeptViewModel { Id = department.Id, Name = department.Name });
            }
            return View(vm);
        }

        [HttpGet]
        public async Task<IActionResult> CreateDept()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateDept(DeptViewModel vm)
        {
            var dept = new Department
            {
                Id = vm.Id,
                Name = vm.Name,

            };

            await _departmentRepo.Save(dept);
            return RedirectToAction("DeptList");


        }

        [HttpGet]
        public async Task<IActionResult> EditDept(int id)
        {
            var dept = await _departmentRepo.GetById(id);
            var vm = new DeptViewModel { Id = dept.Id, Name = dept.Name };
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> EditDept(DeptViewModel vm)
        {
            var dept = new Department
            {
                Id = vm.Id,
                Name = vm.Name,

            };

            await _departmentRepo.Edit(dept);
            return RedirectToAction("DeptList");


        }

        public async Task<IActionResult> DeleteDept(DeptViewModel vm)
        {
            var dept = new Department
            {
                Id = vm.Id,
                Name = vm.Name,
            };
            await _departmentRepo.RemoveData(dept);
            return RedirectToAction("DeptList");
        }
    }
}
