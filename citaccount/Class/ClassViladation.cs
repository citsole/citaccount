using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazored.FluentValidation;
using citaccount.Data;
using FluentValidation;

namespace citaccount.Class
{
    public class ClassViladation
    {
        //Account
        public class AccountValidator : AbstractValidator<TblAcc>
        {
            public AccountValidator()
            {
                RuleFor(x => x.AccNo).NotEmpty().WithMessage("ກະລຸນາໃສ່ເລກບັນຊີກ່ອນ!");
                RuleFor(x => x.Name).NotEmpty().WithMessage("ກະລຸນາໃສ່ຊື່ບັນຊີກ່ອນ!");
            }
        }
        //Province
        public class ProvinceValidator:AbstractValidator<TblProvince>
        {
            public ProvinceValidator()
            {
                RuleFor(x => x.Code).NotEmpty().WithMessage("ກະລຸນາໃສ່ລະຫັດແຂວງກ່ອນ!");
                RuleFor(x => x.Name).NotEmpty().WithMessage("ກະລຸນາໃສ່ຊື່ແຂວງກ່ອນ!");
            }
        }
        //District
        public class DistrictValidator:AbstractValidator<TblDistrict>
        {
            public DistrictValidator()
            {
                RuleFor(x => x.Name).NotEmpty().WithMessage("ກະລຸນາໃສ່ຊື່ເມືອງກ່ອນ!");
                RuleFor(x => x.ProId).NotEmpty().WithMessage("ກະລຸນາເລືອກແຂວງກ່ອນ!");
            }
        }

        //Transections
        public class TransectionValidator:AbstractValidator<TblTransection>
        {
            public TransectionValidator()
            {
                RuleFor(x => x.TranNo).NotEmpty().WithMessage("ກະລຸນາໃສ່ເລກທີອ້າງອີງກ່ອນ!");
                RuleFor(x => x.CreateDate).NotEmpty().WithMessage("ກະລຸນາໃສ່ວັນທີເຮັດທຸລະກຳກ່ອນ!");
                RuleFor(x => x.AccDebit).NotEmpty().WithMessage("ກະລຸນາເລືອກເລກບັນຊີເບື້ອງໜີ້ກ່ອນ!");
                RuleFor(x => x.AccCredit).NotEmpty().WithMessage("ກະລຸນາເລືອກເລກບັນຊີເບື້ອງມີກ່ອນ!");
                RuleFor(x => x.Amount).NotEmpty().WithMessage("ກະລຸນາໃສ່ຈຳນວນເງິນກ່ອນ!");
                RuleFor(x => x.Des).NotEmpty().WithMessage("ກະລຸນາໃສ່ເນື້ອໃນລາຍການເຄື່ອນໄຫວກ່ອນ!");
            }
        }
    }
}
