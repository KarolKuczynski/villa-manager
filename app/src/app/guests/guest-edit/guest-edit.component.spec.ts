import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { GuestEditComponent } from './guest-edit.component';

describe('GuestEditComponent', () => {
  let component: GuestEditComponent;
  let fixture: ComponentFixture<GuestEditComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ GuestEditComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GuestEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
