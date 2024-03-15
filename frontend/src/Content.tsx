import exp from 'constants';
import BowlersList from './Bowlers/BowlersList';
import Header from './Header';
import { useEffect, useState } from 'react';
import { Bowler } from './types/Bowler';
import BowlersCarousel from './Bowlers/BowlersCarousel';

function Content(props: any) {
  const [bowlerData, setBowlerData] = useState<Bowler[]>([]);

  useEffect(() => {
    const fetchBowlerData = async () => {
      const rsp = await fetch('http://localhost:5126/Bowler');
      const b = await rsp.json();
      setBowlerData(b);
    };
    fetchBowlerData();
  }, []);

  return (
    <div>
      <Header />
      <br />
      <br />

      <div>
        <BowlersCarousel bowlerData={bowlerData} />
      </div>
      <br />
      <br />

      <div>
        <BowlersList bowlerData={bowlerData} />
      </div>
    </div>
  );
}

export default Content;
