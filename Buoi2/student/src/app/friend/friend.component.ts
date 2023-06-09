import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ModalDismissReasons, NgbModal } from '@ng-bootstrap/ng-bootstrap';

export class Friend{
  constructor(
    public Id: number,
    public f_name: string,
    public m_name: string,
    public l_name: string,
    public address: string,
    public birthDate: string,
    public score: string,
  ){
  }
}

@Component({
  selector: 'app-friend',
  templateUrl: './friend.component.html',
  styleUrls: ['./friend.component.css']
})
export class FriendComponent implements OnInit{

  closeResult: string;
  friends: any={
    f_name:"1",
    m_name:"2",
    l_name:"3",
    address:"4",
    birthDate:"5",
    score:"6"
  };

  constructor(private HttpClient: HttpClient, private modalServer: NgbModal) {}
  ngOnInit(): void {
    this.getFriends();
  }
  getFriends(){
    this.HttpClient.get<any>('/api/Student/').subscribe(
      response =>{
        console.log(response);
        this.friends = response;
      }
    )
  }
  open(content){
    this.modalServer.open(content,{ariaLabelledBy: 'modal-basic-title'}).result.then((result)=>{
      this.closeResult = `Closed with: ${result}`;
    },(reason)=>{
      this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
    });
  }
  private getDismissReason(reason: any): String {
    if(reason === ModalDismissReasons.ESC){
      return `by pressing ESCC`;
    }else if(reason === ModalDismissReasons.BACKDROP_CLICK){
      return `by clicking on a backdrop`;
    }else{
      return `with ${reason}`
    }
  }
  onSubmit(f: NgForm){
    const url = '/api/Student/';
    this.HttpClient.post(url, f.value).subscribe((result)=>{
      this.ngOnInit();//reload the table
    });
    this.modalServer.dismissAll();//dismiss the modal
  }
}
