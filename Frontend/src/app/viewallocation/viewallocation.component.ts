import { Component, OnInit } from '@angular/core';
import { AllocationService } from '../services/allocation.service';

@Component({
  selector: 'app-viewallocation',
  templateUrl: './viewallocation.component.html',
  styleUrls: ['./viewallocation.component.css']
})
export class ViewallocationComponent implements OnInit {
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

  constructor(private allocation: AllocationService) { }

  ngOnInit(): void {
this.allocation.getallocationdata().subscribe((data)=>
  {
    console.log("success");
    this.allocatedata=JSON.parse(JSON.stringify(data))
  })

  }
  viewpaticipants(item:any)
  {

  }

}
