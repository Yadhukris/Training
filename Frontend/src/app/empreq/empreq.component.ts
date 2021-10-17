import { Component, OnInit } from '@angular/core';
import { Router, RouterLink } from '@angular/router';
import { EmployeeService } from '../services/employee.service';

@Component({
  selector: 'app-empreq',
  templateUrl: './empreq.component.html',
  styleUrls: ['./empreq.component.css']
})
export class EmpreqComponent implements OnInit {

  constructor(private empservice:EmployeeService, private router:Router) { }

  Req=[{  
  Rid:0,
  Empid:"",
  Ename:"",
  Techname:"",
  SuggestedTrainer:"",
  NumberofPart:0,
  Startdate:new Date('12-12-2020'),
  Status:""
}]

  ngOnInit(): void {

    this.empservice.getallreq().subscribe((data)=>
    {
      this.Req=JSON.parse(JSON.stringify(data))
      console.log(this.Req);
    })
  }

  Takeaction(item:any)
  {

    localStorage.setItem("Rid",item.Rid)
    this.router.navigate(["Reqaction"]);

  }
  
  delete(Rid:any)
  {

  }

}
