import { Bowler } from '../types/Bowler';
import React, { useState } from 'react';
import Slider from 'react-slick';
import 'slick-carousel/slick/slick.css';
import 'slick-carousel/slick/slick-theme.css';
// Custom previous arrow component

function BowlersCarousel(props: any) {
  const settings = {
    dots: true,
    infinite: true,
    speed: 500,
    slidesToShow: 3, // Adjust the number of slides shown at a time
    slidesToScroll: 3,
    autoplay: true,
    autoplaySpeed: 2000,
  };

  return (
    <div style={{ padding: '20px', width: '80%', margin: '0 auto' }}>
      <div className="slider-container">
        <Slider {...settings}>
          {props.bowlerData.map((b: Bowler) => (
            <div className="card" key={b.bowlerID}>
              <div className="card-body">
                <h4>{`${b.bowlerFirstName} ${b.bowlerMiddleInit} ${b.bowlerLastName}`}</h4>
                <h5>Team: {b.teamName}</h5>
                <h6>Address: {b.bowlerAddress}</h6>
                <h6>
                  {b.bowlerCity}, {b.bowlerState}, {b.bowlerZip}
                </h6>
                <h6>Phone: {b.bowlerPhoneNumber}</h6>
              </div>
            </div>
          ))}
        </Slider>
      </div>
    </div>
  );
}

export default BowlersCarousel;
