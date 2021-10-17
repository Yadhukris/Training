import { Component, OnInit } from '@angular/core';
import { AllocationService } from '../services/allocation.service';
import { LoginService } from '../services/login.service';

@Component({
  selector: 'app-empviewcal',
  templateUrl: './empviewcal.component.html',
  styleUrls: ['./empviewcal.component.css']
})
export class EmpviewcalComponent implements OnInit {

  allocatedata = [
    {
      Aid: 0,
      Techname: "",
      SuggestedTrainer: "",
      Startdate: new Date('12-12-2020'),
      Enddate: new Date('12-12-2020'),
      Status: "",


    }
  ]

  item={
    Empid:"",
    Ename:"",
    Password:"",
  }

  constructor(private allocation: AllocationService , private loginservice:LoginService) { }

  ngOnInit(): void {
this.allocation.getallocationdata().subscribe((data)=>
  {
    console.log("success");
    this.allocatedata=JSON.parse(JSON.stringify(data))
  })

  let Empid = localStorage.getItem("Empid");
  console.log(Empid);
  this.loginservice.getEmployer(Empid)
        .subscribe((data)=>{
          console.log(data);
          this.item=JSON.parse(JSON.stringify(data))
            })    

  }
  Participate(Aid:any)
  {

  }
}
