using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IEmployer
{
    double CountWage();
}

public class Worker: Person, IEmployer
{

}